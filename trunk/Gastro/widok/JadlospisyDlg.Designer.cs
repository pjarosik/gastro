namespace Gastro.widok
{
    partial class JadlospisyDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbRodzajPosilku = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPotrawa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dgvSkladniki = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lSn1 = new System.Windows.Forms.Label();
            this.lSn2 = new System.Windows.Forms.Label();
            this.lOb = new System.Windows.Forms.Label();
            this.lPdw = new System.Windows.Forms.Label();
            this.lKol1 = new System.Windows.Forms.Label();
            this.lKol2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 20);
            this.tbName.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(131, 40);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(268, 20);
            this.dtpData.TabIndex = 3;
            // 
            // cbRodzajPosilku
            // 
            this.cbRodzajPosilku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodzajPosilku.FormattingEnabled = true;
            this.cbRodzajPosilku.Items.AddRange(new object[] {
            "Śniadanie 1",
            "Śniadanie 2",
            "Obiad",
            "Podwieczorek",
            "Kolacja 1",
            "Kolacja 2"});
            this.cbRodzajPosilku.Location = new System.Drawing.Point(131, 127);
            this.cbRodzajPosilku.Name = "cbRodzajPosilku";
            this.cbRodzajPosilku.Size = new System.Drawing.Size(168, 21);
            this.cbRodzajPosilku.TabIndex = 4;
            this.cbRodzajPosilku.SelectedIndexChanged += new System.EventHandler(this.cbRodzajPosilku_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj posiłku:";
            // 
            // cbPotrawa
            // 
            this.cbPotrawa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPotrawa.FormattingEnabled = true;
            this.cbPotrawa.Location = new System.Drawing.Point(131, 165);
            this.cbPotrawa.Name = "cbPotrawa";
            this.cbPotrawa.Size = new System.Drawing.Size(346, 21);
            this.cbPotrawa.TabIndex = 6;
            this.cbPotrawa.SelectedIndexChanged += new System.EventHandler(this.cbPotrawa_SelectedIndexChanged);
            this.cbPotrawa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbPotrawa_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa posiłku:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(611, 430);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Zapisz";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(530, 430);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dgvSkladniki
            // 
            this.dgvSkladniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladniki.Location = new System.Drawing.Point(15, 224);
            this.dgvSkladniki.Name = "dgvSkladniki";
            this.dgvSkladniki.Size = new System.Drawing.Size(671, 200);
            this.dgvSkladniki.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Składniki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Śniadanie 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Śniadanie 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Obiad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Podwieczorek:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Kolacja 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Kolacja 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lKol2);
            this.groupBox1.Controls.Add(this.lKol1);
            this.groupBox1.Controls.Add(this.lPdw);
            this.groupBox1.Controls.Add(this.lOb);
            this.groupBox1.Controls.Add(this.lSn2);
            this.groupBox1.Controls.Add(this.lSn1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(498, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 175);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lSn1
            // 
            this.lSn1.AutoSize = true;
            this.lSn1.Location = new System.Drawing.Point(110, 27);
            this.lSn1.Name = "lSn1";
            this.lSn1.Size = new System.Drawing.Size(66, 13);
            this.lSn1.TabIndex = 20;
            this.lSn1.Text = "Nie wybrano";
            // 
            // lSn2
            // 
            this.lSn2.AutoSize = true;
            this.lSn2.Location = new System.Drawing.Point(110, 51);
            this.lSn2.Name = "lSn2";
            this.lSn2.Size = new System.Drawing.Size(66, 13);
            this.lSn2.TabIndex = 21;
            this.lSn2.Text = "Nie wybrano";
            // 
            // lOb
            // 
            this.lOb.AutoSize = true;
            this.lOb.Location = new System.Drawing.Point(110, 77);
            this.lOb.Name = "lOb";
            this.lOb.Size = new System.Drawing.Size(66, 13);
            this.lOb.TabIndex = 22;
            this.lOb.Text = "Nie wybrano";
            // 
            // lPdw
            // 
            this.lPdw.AutoSize = true;
            this.lPdw.Location = new System.Drawing.Point(110, 101);
            this.lPdw.Name = "lPdw";
            this.lPdw.Size = new System.Drawing.Size(66, 13);
            this.lPdw.TabIndex = 23;
            this.lPdw.Text = "Nie wybrano";
            // 
            // lKol1
            // 
            this.lKol1.AutoSize = true;
            this.lKol1.Location = new System.Drawing.Point(110, 127);
            this.lKol1.Name = "lKol1";
            this.lKol1.Size = new System.Drawing.Size(66, 13);
            this.lKol1.TabIndex = 24;
            this.lKol1.Text = "Nie wybrano";
            // 
            // lKol2
            // 
            this.lKol2.AutoSize = true;
            this.lKol2.Location = new System.Drawing.Point(110, 154);
            this.lKol2.Name = "lKol2";
            this.lKol2.Size = new System.Drawing.Size(66, 13);
            this.lKol2.TabIndex = 25;
            this.lKol2.Text = "Nie wybrano";
            // 
            // JadlospisyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSkladniki);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPotrawa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRodzajPosilku);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JadlospisyDlg";
            this.Text = "Zarządzaj jadłospisem";
            this.Load += new System.EventHandler(this.JadlospisyDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladniki)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbRodzajPosilku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPotrawa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridView dgvSkladniki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lKol2;
        private System.Windows.Forms.Label lKol1;
        private System.Windows.Forms.Label lPdw;
        private System.Windows.Forms.Label lOb;
        private System.Windows.Forms.Label lSn2;
        private System.Windows.Forms.Label lSn1;
    }
}