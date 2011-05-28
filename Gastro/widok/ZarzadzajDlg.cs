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
    public partial class ZarzadzajDlg : Form
    {
        List<object> objects;
        public enum Mode { Produkty, Potrawy };
        Mode activeMode;

        public ZarzadzajDlg(Mode mode)
        {
            this.activeMode = mode;
            InitializeComponent();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (objects.Count < 1)
                return;

            switch (activeMode)
            {
                case Mode.Potrawy:
                    Utils.dataFilter(tbName.Text, objects);
                    dgvContent.DataSource = Utils.dataFilter(tbName.Text, objects);
                    break;

                case Mode.Produkty:
                    Utils.dataFilter(tbName.Text, objects);
                    dgvContent.DataSource = Utils.dataFilter(tbName.Text, objects);
                    break;
            }
        }

        private void updateDGVContent()
        {
            dgvContent.DataSource = null;
            objects = DBProvider.getPotrawy();
            dgvContent.DataSource = objects;
        }

        private void ZarzadzajDlg_Load(object sender, EventArgs e)
        {
            switch (activeMode)
            {
                case Mode.Potrawy:
                    updateDGVContent();
                    btNew.Text += " potrawę";
                    this.Text += " potrawami";
                    
                    setupDGV(Mode.Potrawy);
                    break;

                case Mode.Produkty:
                    objects = DBProvider.getProdukty();
                    dgvContent.DataSource = objects;
                    btNew.Text += " produkt";
                    this.Text += " produktami";
                    break;
            }
        }

        private void setupDGV(Mode mode)
        {
            if (dgvContent.Columns.Count < 1)
            {
                // MessageBox.Show(Parent, "Brak danych w bazie.", "Uwaga",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            switch (mode)
            {
                case Mode.Potrawy:
                    preapareDGVForPotrawy();
                    break;
                case Mode.Produkty:
                    preapareDGVForProdukt();
                    break;
            }
        }
        private void preapareDGVForPotrawy()
        {
            dgvContent.Columns[0].Width = 400;
            dgvContent.Columns[dgvContent.Columns.Count - 1].Visible = false;
            
            //dgvContent.Columns.Add(new DataGridViewColumn(new DataGridViewComboBoxCell()));
            //dgvContent.Rows.Insert(0,new DataGridViewRow());
            //dgvContent.AllowUserToAddRows = false;

            if (dgvContent.SelectedCells.Count != 0)
                dgvContent.Rows[dgvContent.SelectedCells[0].RowIndex].Selected = true;
        }
        private void preapareDGVForProdukt()
        {
            dgvContent.Columns[0].Width = 400;
        }

        private void dgvContent_DataSourceChanged(object sender, EventArgs e)
        {
                setupDGV(Mode.Potrawy);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            switch (activeMode)
            {
                case Mode.Potrawy:
                    if (new PotrawyDlg(PotrawyDlg.Mode.New, "").ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        updateDGVContent();
                    break;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvContent.SelectedCells.Count < 1)
            {
                MessageBox.Show(this, "Zaznacz wiersz do edycji.", "Uwaga!");
                return;
            }

            switch (activeMode)
            {
                case Mode.Potrawy:
                    new PotrawyDlg(PotrawyDlg.Mode.Edit, dgvContent.Rows[dgvContent.SelectedCells[0].RowIndex].Cells[dgvContent.Columns.Count-1].Value.ToString()).ShowDialog();
                    //new PotrawyDlg(PotrawyDlg.Mode.Edit, dgvContent.SelectedRows[0].Cells[dgvContent.SelectedRows[0].Cells.Count - 1].Value.ToString()).ShowDialog();
                    updateDGVContent();
                    break;
            }
        }

        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           dgvContent.Rows[dgvContent.SelectedCells[0].RowIndex].Selected = true;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (dgvContent.SelectedCells.Count < 1)
            {
                MessageBox.Show(this,"Zaznacz wiersz do usunięcia.", "Uwaga!");
                return;
            }

            switch (activeMode)
            {
                case Mode.Potrawy:
                    //new PotrawyDlg(PotrawyDlg.Mode.Edit, dgvContent.Rows[dgvContent.SelectedCells[0].RowIndex].Cells[dgvContent.Columns.Count - 1].Value.ToString()).ShowDialog();
                    if(DBProvider.removePotrawa(dgvContent.Rows[dgvContent.SelectedCells[0].RowIndex].Cells[dgvContent.Columns.Count - 1].Value.ToString()))
                        MessageBox.Show(this, "Usunięto potrawę.", "Uwaga!");
                    updateDGVContent();
                    
                    break;
            }
        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
