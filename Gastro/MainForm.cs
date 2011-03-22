using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Gastro.logika;

namespace Gastro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int lastStatus = -1;
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
                    this.backgroundThread.RunWorkerAsync(dlg.FileName);
                    //Thread thrd = new Thread(CSVReader.readFile);
                    //thrd.Start(dlg.FileName);
                }
            }
        }

        private void backgroundThread_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string path = (string)e.Argument;
            e.Result = CSVReader.readFile(path,worker);
        }

        private void backgroundThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(lastStatus!=e.ProgressPercentage)
            {
                Debug.WriteLine("Progress: " + e.ProgressPercentage);
                lastStatus = e.ProgressPercentage;
                progressBar.Value = lastStatus;
            }
        }

        private void backgroundThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool result = (bool)e.Result;
            if (result)
                MessageBox.Show("Dane wczytano poprawnie");
            else
                MessageBox.Show("Wystapil blad podczas wczytywania danych");
        }
    }
}