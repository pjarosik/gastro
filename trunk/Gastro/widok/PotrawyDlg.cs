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

        public PotrawyDlg()
        {
            InitializeComponent();
        }

        private void PotrawyDlg_Load(object sender, EventArgs e)
        {
            productsName = DBProvider.getProductsName();
            lbProdukty.DataSource = productsName;
        }

        private void tbNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            lbProdukty.DataSource = Utils.dataFilter(tbNazwaProduktu.Text,productsName);
        }

        private void lbProdukty_DragOver(object sender, DragEventArgs e)
        {

        }

        private void lbProdukty_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void lbProdukty_DragLeave(object sender, EventArgs e)
        {
        }

        private void lbProdukty_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgvSkladniki.DataSource = null;
            componentsList.Add(new logika.Component(((ListBox)sender).SelectedValue.ToString(), 0));
            dgvSkladniki.DataSource = componentsList;
            dgvSkladniki.Refresh();
        }
    }
}
