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
            this.lbProdukty = new System.Windows.Forms.ListBox();
            this.tbNazwaProduktu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSkladniki = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategory = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukty
            // 
            this.lbProdukty.FormattingEnabled = true;
            this.lbProdukty.Location = new System.Drawing.Point(12, 55);
            this.lbProdukty.Name = "lbProdukty";
            this.lbProdukty.Size = new System.Drawing.Size(306, 355);
            this.lbProdukty.TabIndex = 0;
            this.lbProdukty.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbProdukty_MouseDoubleClick);
            // 
            // tbNazwaProduktu
            // 
            this.tbNazwaProduktu.Location = new System.Drawing.Point(122, 6);
            this.tbNazwaProduktu.Name = "tbNazwaProduktu";
            this.tbNazwaProduktu.Size = new System.Drawing.Size(196, 20);
            this.tbNazwaProduktu.TabIndex = 1;
            this.tbNazwaProduktu.TextChanged += new System.EventHandler(this.tbNazwaProduktu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtruj produkty: ";
            // 
            // dgvSkladniki
            // 
            this.dgvSkladniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladniki.Location = new System.Drawing.Point(380, 108);
            this.dgvSkladniki.MultiSelect = false;
            this.dgvSkladniki.Name = "dgvSkladniki";
            this.dgvSkladniki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvSkladniki.Size = new System.Drawing.Size(394, 304);
            this.dgvSkladniki.TabIndex = 3;
            this.dgvSkladniki.DataSourceChanged += new System.EventHandler(this.dgvSkladniki_DataSourceChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa potrawy:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Podaj nazwę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Typ:";
            // 
            // cbKategory
            // 
            this.cbKategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategory.FormattingEnabled = true;
            this.cbKategory.Items.AddRange(new object[] {
            "Śniadanie 1",
            "Śniadanie 2",
            "Obiad",
            "Podwieczorek",
            "Kolacja"});
            this.cbKategory.Location = new System.Drawing.Point(491, 44);
            this.cbKategory.Name = "cbKategory";
            this.cbKategory.Size = new System.Drawing.Size(135, 21);
            this.cbKategory.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(601, 431);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Zapisz";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(476, 431);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Składaniki potrawy:";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(324, 246);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(49, 23);
            this.btRemove.TabIndex = 11;
            this.btRemove.Text = "<-";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(324, 198);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(49, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "->";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // PotrawyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 466);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbKategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkladniki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNazwaProduktu);
            this.Controls.Add(this.lbProdukty);
            this.Name = "PotrawyDlg";
            this.Text = "Nowa potrawa";
            this.Load += new System.EventHandler(this.PotrawyDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukty;
        private System.Windows.Forms.TextBox tbNazwaProduktu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSkladniki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategory;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
    }
}