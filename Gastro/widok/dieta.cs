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

            for (int i = 0; i < dgv.Columns.Count; i++)
                dgv2.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            dgv2.Rows.Add();
        }

        private void clearDGV2()
        {

            dgv2.Rows[0].Cells[0].Value = "Podsumowanie: ";
            for (int i = 3; i < dgv.Columns.Count; i++)
            {
                dgv2.Rows[0].Cells[i].Value = "";
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
                dgv2.Rows[0].Cells[i].Value =  summary[i - 3]; 
            }
            dgv2.Rows[0].Cells[0].Value = "Podsumowanie: ";
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
            setDgv2();
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
