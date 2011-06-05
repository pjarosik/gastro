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
        }

        private void cbJadlospisy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<object> list = new List<object>();
            //list.Add();
            dgv.DataSource = DBProvider.getJadlospis(jadlospis[cbJadlospisy.SelectedIndex].id_jadlospis.ToString());
        }
    }
}
