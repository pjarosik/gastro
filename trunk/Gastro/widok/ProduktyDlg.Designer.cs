namespace Gastro.widok
{
    partial class ProduktyDlg
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
            this.cbNazwaProduktu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNazwaProduktu
            // 
            this.cbNazwaProduktu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazwaProduktu.FormattingEnabled = true;
            this.cbNazwaProduktu.Location = new System.Drawing.Point(106, 29);
            this.cbNazwaProduktu.Name = "cbNazwaProduktu";
            this.cbNazwaProduktu.Size = new System.Drawing.Size(543, 21);
            this.cbNazwaProduktu.TabIndex = 0;
            this.cbNazwaProduktu.SelectedIndexChanged += new System.EventHandler(this.cbNazwaProduktu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa produktu:";
            // 
            // ProduktyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNazwaProduktu);
            this.Name = "ProduktyDlg";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.Produkty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNazwaProduktu;
        private System.Windows.Forms.Label label1;
    }
}