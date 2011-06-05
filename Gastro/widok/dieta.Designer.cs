namespace Gastro.widok
{
    partial class dieta
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbJadlospisy = new System.Windows.Forms.ComboBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 72);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(701, 275);
            this.dgv.TabIndex = 0;
            this.dgv.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_ColumnWidthChanged);
            this.dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(15, 25);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 1;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jadłospis:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbJadlospisy
            // 
            this.cbJadlospisy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJadlospisy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJadlospisy.FormattingEnabled = true;
            this.cbJadlospisy.Location = new System.Drawing.Point(393, 26);
            this.cbJadlospisy.Name = "cbJadlospisy";
            this.cbJadlospisy.Size = new System.Drawing.Size(273, 21);
            this.cbJadlospisy.TabIndex = 2;
            this.cbJadlospisy.SelectedIndexChanged += new System.EventHandler(this.cbJadlospisy_SelectedIndexChanged);
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.ColumnHeadersVisible = false;
            this.dgv2.Location = new System.Drawing.Point(12, 353);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(701, 94);
            this.dgv2.TabIndex = 5;
            this.dgv2.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv2_ColumnWidthChanged);
            this.dgv2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv2_Scroll);
            // 
            // dieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJadlospisy);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dgv);
            this.Name = "dieta";
            this.Text = "Dieta";
            this.Load += new System.EventHandler(this.dieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbJadlospisy;
        private System.Windows.Forms.DataGridView dgv2;
    }
}