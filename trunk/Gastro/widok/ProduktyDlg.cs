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
    public partial class ProduktyDlg : Form
    {
        public ProduktyDlg()
        {
            InitializeComponent();
        }

        private void Produkty_Load(object sender, EventArgs e)
        {
            cbNazwaProduktu.DataSource = DBProvider.getProductsName();
        }

        private void cbNazwaProduktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string text = this.cbNazwaProduktu.Text;
            //string[] suggestions = GetNameSuggestions(text);

            //this.ComboQuery.AutoCompleteCustomSource.Clear();
            //this.ComboQuery.AutoCompleteCustomSource.AddRange(suggestions);

        }
    }
}
