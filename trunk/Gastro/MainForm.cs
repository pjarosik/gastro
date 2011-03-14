using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Gastro.logika;

namespace Gastro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Chcesz zamknąć program?","Pytanie",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void importujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\";
            dlg.Filter = "Datasheet (*.csv)|*.csv"; //|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.CheckFileExists)
                {
                    Debug.WriteLine("Opened file: " + dlg.FileName);
                    CSVReader.readFile(dlg.FileName);
                }
            }
        }
    }
}