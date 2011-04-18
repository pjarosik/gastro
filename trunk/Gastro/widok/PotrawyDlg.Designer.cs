namespace Gastro.widok
{
    partial class PotrawyDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbProdukty = new System.Windows.Forms.ListBox();
            this.tbNazwaProduktu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSkladniki = new System.Windows.Forms.DataGridView();
            this.potrawyLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrawyLogicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukty
            // 
            this.lbProdukty.FormattingEnabled = true;
            this.lbProdukty.Location = new System.Drawing.Point(12, 55);
            this.lbProdukty.Name = "lbProdukty";
            this.lbProdukty.Size = new System.Drawing.Size(306, 381);
            this.lbProdukty.TabIndex = 0;
            this.lbProdukty.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbProdukty_DragEnter);
            this.lbProdukty.DragOver += new System.Windows.Forms.DragEventHandler(this.lbProdukty_DragOver);
            this.lbProdukty.DragLeave += new System.EventHandler(this.lbProdukty_DragLeave);
            this.lbProdukty.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbProdukty_MouseDoubleClick);
            // 
            // tbNazwaProduktu
            // 
            this.tbNazwaProduktu.Location = new System.Drawing.Point(122, 6);
            this.tbNazwaProduktu.Name = "tbNazwaProduktu";
            this.tbNazwaProduktu.Size = new System.Drawing.Size(584, 20);
            this.tbNazwaProduktu.TabIndex = 1;
            this.tbNazwaProduktu.TextChanged += new System.EventHandler(this.tbNazwaProduktu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa produktu: ";
            // 
            // dgvSkladniki
            // 
            this.dgvSkladniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladniki.Location = new System.Drawing.Point(396, 55);
            this.dgvSkladniki.Name = "dgvSkladniki";
            this.dgvSkladniki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvSkladniki.Size = new System.Drawing.Size(348, 381);
            this.dgvSkladniki.TabIndex = 3;
            // 
            // potrawyLogicBindingSource
            // 
            this.potrawyLogicBindingSource.DataSource = typeof(Gastro.logika.PotrawyLogic);
            // 
            // PotrawyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 466);
            this.Controls.Add(this.dgvSkladniki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNazwaProduktu);
            this.Controls.Add(this.lbProdukty);
            this.Name = "PotrawyDlg";
            this.Text = "Potrawy";
            this.Load += new System.EventHandler(this.PotrawyDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrawyLogicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukty;
        private System.Windows.Forms.TextBox tbNazwaProduktu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSkladniki;
        private System.Windows.Forms.BindingSource potrawyLogicBindingSource;
    }
}