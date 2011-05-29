using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gastro.logika;
using System.Collections;

namespace Gastro.widok
{
    public partial class JadlospisyDlg : Form
    {
        List<Potrawy> currentList;
        List<object> componentsList = new List<object>();

        Jadlospi jadlospisToSave = new Jadlospi();

        public JadlospisyDlg()
        {
            InitializeComponent();
        }

        private void JadlospisyDlg_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show(this, "Nie wprowadzono nazwy dla jadlospisu.", "Uwaga!");
                return;
            }

            if (DBProvider.checkIfJadlospisExist(tbName.Text))
            {
                MessageBox.Show(this, "Wprowadzona nazwa dla jadlospisu juz istnieje. Wprowadz inną nazwę.", "Uwaga");
                return;
            }

            jadlospisToSave.data = dtpData.Value.ToShortDateString();
            jadlospisToSave.nazwa = tbName.Text;
            DBProvider.AddJadlospis(jadlospisToSave);
            Close();
        }

        private void load()
        {
            cbRodzajPosilku.SelectedIndex = 0;
            cbPotrawa.SelectedIndex = -1;
            updateCb();
        }

        private void updateCb()
        {
            componentsList.Clear();
            dgvSkladniki.DataSource = null;
            cbPotrawa.DataSource = null;
            currentList = DBProvider.getPotrawaByCategory(cbRodzajPosilku.Text);
            cbPotrawa.DataSource = currentList;
            cbPotrawa.DisplayMember = "nazwa";
        }

        private void cbRodzajPosilku_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCb();
        }

        private void cbPotrawa_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
            if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Down) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.PageUp) ||
                (e.KeyCode == Keys.PageDown) ||
                (e.KeyCode == Keys.Home) ||
                (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cbPotrawa.Text;

            // Find the first match for the typed value.
            index = this.cbPotrawa.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cbPotrawa.Items[index].ToString();

                // Select this item from the list.
                this.cbPotrawa.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cbPotrawa.SelectionStart = actual.Length;
                this.cbPotrawa.SelectionLength = found.Length;
            }
        }

        private void cbPotrawa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbPotrawa.SelectedIndex == -1)
                return;

            dgvSkladniki.DataSource = null;
            componentsList.Clear();


            Potrawy tmpPotrawa = new Potrawy();
            Potrawy potrawa = new Potrawy();
            tmpPotrawa.ID_potrawy = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
            if ((potrawa = DBProvider.getIfExists(tmpPotrawa)) != null)
            {
                foreach (logika.Component sklad in DBProvider.getComponents(potrawa))
                    componentsList.Add(new logika.Component(sklad.Name, sklad.count));

                dgvSkladniki.DataSource = componentsList;
                dgvSkladniki.Columns[0].Width = 450;
            }
            updateStatus();
        }

        private void updateStatus()
        {
            switch (cbRodzajPosilku.SelectedIndex)
            {
                case 0: lSn1.Text = "OK";
                    jadlospisToSave.id_sniadanie1 = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
                case 1: lSn2.Text = "OK";
                    jadlospisToSave.id_sniadanie2 = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
                case 2: lOb.Text = "OK";
                    jadlospisToSave.id_obiad = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
                case 3: lPdw.Text = "OK";
                    jadlospisToSave.id_podwieczorek = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
                case 4: lKol1.Text = "OK";
                    jadlospisToSave.id_kolacja1 = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
                case 5: lKol2.Text = "OK";
                    jadlospisToSave.id_kolacja2 = currentList[cbPotrawa.SelectedIndex].ID_potrawy;
                    break;
            }
        }
    }
}
