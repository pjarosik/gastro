using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gastro.logika;

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
        }

        private void tbNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            lbProdukty.DataSource = Utils.dataFilter(tbNazwaProduktu.Text,productsName);
        }

        private void lbProdukty_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //addNew();
        }

        private void addNew()
        {
            if (lbProdukty.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Uwaga", "Proszę wybrać produkt");
                return;
            }

            dgvSkladniki.DataSource = null;
            componentsList.Add(new logika.Component((lbProdukty.SelectedItem.ToString()), 1));
            dgvSkladniki.DataSource = componentsList;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Zapisano (fake)", "Uwaga");
        }

        private void dgvSkladniki_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvSkladniki.Columns.Count < 1)
                return;

            dgvSkladniki.Columns[0].Width = 200;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            addNew();
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
