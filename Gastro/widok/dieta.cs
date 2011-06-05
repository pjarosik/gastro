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
    public partial class dieta : Form
    {
        List<Jadlospi> jadlospis;
        public dieta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dieta_Load(object sender, EventArgs e)
        {
            updateData();
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dgv2.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                dgv2.Rows.Add();
            }
        }

        private void clearDGV2()
        {
            if (dgv2.Columns.Count > 0)
            {
                dgv2.Rows[0].Cells[0].Value = "Podsumowanie: ";
                dgv2.Rows[1].Cells[0].Value = "Norma: ";
                for (int i = 3; i < dgv.Columns.Count; i++)
                {
                    dgv2.Rows[0].Cells[i].Value = "";
                    dgv2.Rows[1].Cells[i].Value = "";
                }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            clearDGV2();
            updateData();
        }

        private void updateData()
        {
            if (jadlospis != null)
                jadlospis.Clear();

            dgv.DataSource = null;
            jadlospis = DBProvider.getJadlospisyByDate(dtp.Value.ToShortDateString());
            cbJadlospisy.DataSource = DBProvider.getJadlospisyByDate(dtp.Value.ToShortDateString());
            cbJadlospisy.DisplayMember = "nazwa";
        }

        private void setDgv2()
        {
            double[] summary = new double[23];
            for (int i = 3; i < dgv.Columns.Count; i++)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    summary[i - 3] += double.Parse(row.Cells[i].Value.ToString());
                }
                dgv2.Rows[0].Cells[i].Value = summary[i - 3]; 
            }
            dgv2.Rows[0].Cells[0].Value = "Podsumowanie: ";
            dgv2.Rows[1].Cells[0].Value = "Normy: ";

            dgv2.Rows[1].Cells[4].Value = summary[1] * 100 / 2250;
            dgv2.Rows[1].Cells[5].Value = summary[2] * 100 / 88;
            dgv2.Rows[1].Cells[6].Value = summary[3] * 100 / 75;
            dgv2.Rows[1].Cells[7].Value = summary[4] * 100 / 575;
            dgv2.Rows[1].Cells[8].Value = summary[5] * 100 / 3500;
            dgv2.Rows[1].Cells[9].Value = summary[6] * 100 / 1100;
            dgv2.Rows[1].Cells[10].Value = summary[7] * 100 / 800;
            dgv2.Rows[1].Cells[11].Value = summary[8] * 100 / 360;
            dgv2.Rows[1].Cells[12].Value = summary[9] * 100 / 12.5;
            dgv2.Rows[1].Cells[13].Value = summary[10] * 100 / 15;
            dgv2.Rows[1].Cells[14].Value = summary[11] * 100 / 2.0;
            dgv2.Rows[1].Cells[15].Value = summary[12] * 100 / 800;
            dgv2.Rows[1].Cells[16].Value = summary[13] * 100 / 10;
            dgv2.Rows[1].Cells[17].Value = summary[14] * 100 / 10;
            dgv2.Rows[1].Cells[18].Value = summary[15] * 100 / 1.8;
            dgv2.Rows[1].Cells[19].Value = summary[16] * 100 / 2.4;
            dgv2.Rows[1].Cells[20].Value = summary[17] * 100 / 21;
            dgv2.Rows[1].Cells[21].Value = summary[18] * 100 / 2.2;
            dgv2.Rows[1].Cells[22].Value = summary[19] * 100 / 300;
            dgv2.Rows[1].Cells[23].Value = summary[20] * 100 / 3.0;
            dgv2.Rows[1].Cells[24].Value = summary[21] * 100 / 70;
        }

        private void cbJadlospisy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            dgv.DataSource = DBProvider.getJadlospis(jadlospis[cbJadlospisy.SelectedIndex].id_jadlospis.ToString());
            clearDGV2();
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgv2.FirstDisplayedCell = this.dgv2[this.dgv.FirstDisplayedCell.ColumnIndex, 0];
        }

        private void dgv2_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgv.FirstDisplayedCell = this.dgv[this.dgv2.FirstDisplayedCell.ColumnIndex, 0];
        }

        private void dgv2_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dgv.Columns[e.Column.Index].Width = e.Column.Width;
        }

        private void dgv_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dgv2.Columns[e.Column.Index].Width = e.Column.Width;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 2)
                e.Value = String.Format("{0:F2}", e.Value);
        }

        private void dgv_DataSourceChanged(object sender, EventArgs e)
        {
            //setDgv2();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //setDgv2();
        }

        private void btPodsumowanie_Click(object sender, EventArgs e)
        {
            if (dgv.Columns.Count > 0) 
                setDgv2();
            else
                MessageBox.Show("Brak danych.");

        }

        private void dgv2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 2)
                e.Value = String.Format("{0:F2}", e.Value);
        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
