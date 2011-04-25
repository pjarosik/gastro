namespace Gastro.widok
{
    partial class JadłospisDlg
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSkladniki = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazwaProduktu = new System.Windows.Forms.TextBox();
            this.lbProdukty = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(324, 206);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(49, 23);
            this.btAdd.TabIndex = 25;
            this.btAdd.Text = "->";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(324, 254);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(49, 23);
            this.btRemove.TabIndex = 24;
            this.btRemove.Text = "<-";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Potrawy jadłospisu:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(476, 439);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(601, 439);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Zapisz";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Podaj nazwę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwa jadłospisu:";
            // 
            // dgvSkladniki
            // 
            this.dgvSkladniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladniki.Location = new System.Drawing.Point(380, 116);
            this.dgvSkladniki.MultiSelect = false;
            this.dgvSkladniki.Name = "dgvSkladniki";
            this.dgvSkladniki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvSkladniki.Size = new System.Drawing.Size(394, 304);
            this.dgvSkladniki.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtruj jadłospis: ";
            // 
            // tbNazwaProduktu
            // 
            this.tbNazwaProduktu.Location = new System.Drawing.Point(122, 14);
            this.tbNazwaProduktu.Name = "tbNazwaProduktu";
            this.tbNazwaProduktu.Size = new System.Drawing.Size(196, 20);
            this.tbNazwaProduktu.TabIndex = 14;
            // 
            // lbProdukty
            // 
            this.lbProdukty.FormattingEnabled = true;
            this.lbProdukty.Location = new System.Drawing.Point(12, 63);
            this.lbProdukty.Name = "lbProdukty";
            this.lbProdukty.Size = new System.Drawing.Size(306, 355);
            this.lbProdukty.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(491, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Podaj datę (dd-mm-rrrr)";
            // 
            // JadłospisDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 484);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkladniki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNazwaProduktu);
            this.Controls.Add(this.lbProdukty);
            this.Name = "JadłospisDlg";
            this.Text = "Nowy jadłospis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSkladniki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazwaProduktu;
        private System.Windows.Forms.ListBox lbProdukty;
        private System.Windows.Forms.TextBox textBox2;

    }
}