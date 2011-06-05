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
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            if(jadlospis!=null)
                jadlospis.Clear();

            dgv.DataSource = null;
            jadlospis = DBProvider.getJadlospisyByDate(dtp.Value.ToShortDateString());
            cbJadlospisy.DataSource = DBProvider.getJadlospisyByDate(dtp.Value.ToShortDateString());
            cbJadlospisy.DisplayMember = "nazwa";

            for (int i = 0; i < dgv.Columns.Count; i++)
                dgv2.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            dgv2.Rows.Add();

            setDgv2();


        }
        private void setDgv2()
        {
            double[] summary = new double[23];
            for (int i = 3; i < 25; i++)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    summary[i - 3] += double.Parse(row.Cells[i].Value.ToString());
                }
                dgv2.Rows[0].Cells[0].Value = "Podsumowanie: ";
                dgv2.Rows[0].Cells[i].Value = summary[i - 3].ToString();
            }
        }

        private void cbJadlospisy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            dgv.DataSource = DBProvider.getJadlospis(jadlospis[cbJadlospisy.SelectedIndex].id_jadlospis.ToString());

            dgv.Rows.Add(2);
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
    }
}
