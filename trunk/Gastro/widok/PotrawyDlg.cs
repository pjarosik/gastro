using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gastro.logika;
using System.Diagnostics;

namespace Gastro.widok
{
    public partial class PotrawyDlg : Form
    {
        List<object> productsName;
        List<logika.Component> componentsList = new List<logika.Component>();

        public enum Mode { New, Edit };
        Mode activeMode;
        string ID_potrawy;

        public PotrawyDlg(Mode mode,string ID_potrawy)
        {
            this.activeMode = mode;
            this.ID_potrawy = ID_potrawy;
            InitializeComponent();
        }

        private void PotrawyDlg_Load(object sender, EventArgs e)
        {
            productsName = DBProvider.getProductsName();
            lbProdukty.DataSource = productsName;

            if (activeMode == Mode.New)
                cbKategory.SelectedIndex = 0;
            // temporary disabled
            //else
            //    loadPotrawy();
        }


        private void loadPotrawy()
        {
            Potrawy potrawa = new Potrawy();
            potrawa.ID_potrawy = decimal.Parse(ID_potrawy);
            if ((potrawa = DBProvider.getIfExists(potrawa)) != null)
            {
                dgvSkladniki.DataSource = DBProvider.getSkladniki(potrawa);

            }
            else
                MessageBox.Show("Wybrana potrawa nie istnieje.blad!!");
        }

        private void tbNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            lbProdukty.DataSource = Utils.dataFilter(tbNazwaProduktu.Text,productsName);
        }

        private void lbProdukty_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //addNew();
        }

        private void addNewSkladnik()
        {
            if (lbProdukty.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Uwaga", "Proszę wybrać produkt");
                return;
            }

            dgvSkladniki.DataSource = null;
            
            logika.Component comp;
            if ((comp = findElement(lbProdukty.SelectedItem.ToString())) != null)
                comp.count += 1;
            else
                componentsList.Add(new logika.Component((lbProdukty.SelectedItem.ToString()), 1));

            dgvSkladniki.DataSource = componentsList;
        }

        private logika.Component findElement(string name)
        {
            foreach (logika.Component comp in componentsList)
            {
                if (comp.name == name)
                    return comp;
            }
            return null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Skladniki> getSkladniki()
        {
            List<Skladniki> skladniki = new List<Skladniki>();
            foreach (DataGridViewRow row in dgvSkladniki.Rows)
            {
                Skladniki skladnik = new Skladniki();
                Produkty tmp = new Produkty();
                tmp.nazwa_produktu = row.Cells[0].Value.ToString();

                skladnik.ID_produktu = DBProvider.getIfExists(tmp).numer_kodowy;
                skladnik.ilosc = float.Parse(row.Cells[1].Value.ToString());
                
                skladniki.Add(skladnik);
            }
            return skladniki;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show(this, "Nie wprowadzono nazwy dla potrawy.", "Uwaga");
                return;
            }

            if (dgvSkladniki.Rows.Count < 1)
            {
                MessageBox.Show(this, "Nie dodano składników.", "Uwaga");
                return;
            }

            Potrawy potrawa = new Potrawy();
            potrawa.kategoria = cbKategory.Text;
            potrawa.nazwa = tbName.Text;
            if (DBProvider.getIfExists(potrawa) == null)
            {
                DBProvider.addPotrawa(potrawa, getSkladniki());
                Close();
            }
            else
            {
                MessageBox.Show(this, "Potrawa o podanej nazwie już istnieje.", "Uwaga");
                return;
            }
        }

        private void dgvSkladniki_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvSkladniki.Columns.Count < 1)
                return;

            dgvSkladniki.Columns[0].Width = 200;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            addNewSkladnik();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (dgvSkladniki.SelectedCells.Count < 1)
            {
                MessageBox.Show(this, "Zaznacz element aby usunąć", "Uwaga");
                return;
            }

            int toRemove = dgvSkladniki.SelectedCells[0].RowIndex;//.Cells[0].Value.ToString();
            dgvSkladniki.DataSource = null;
            componentsList.RemoveAt(toRemove);
            dgvSkladniki.DataSource = componentsList;
        }
    }
}
