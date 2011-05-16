namespace Gastro
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potrawyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundThread = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.zarzadzajToolStripMenuItem,
            this.bazaDanychToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.zamknijToolStripMenuItem.Text = "&Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // zarzadzajToolStripMenuItem
            // 
            this.zarzadzajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potrawyToolStripMenuItem,
            this.produktyToolStripMenuItem});
            this.zarzadzajToolStripMenuItem.Name = "zarzadzajToolStripMenuItem";
            this.zarzadzajToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.zarzadzajToolStripMenuItem.Text = "Zarządzaj";
            // 
            // potrawyToolStripMenuItem
            // 
            this.potrawyToolStripMenuItem.Name = "potrawyToolStripMenuItem";
            this.potrawyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.potrawyToolStripMenuItem.Text = "Potrawy";
            this.potrawyToolStripMenuItem.Click += new System.EventHandler(this.potrawyToolStripMenuItem_Click);
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.produktyToolStripMenuItem.Text = "Produkty";
            this.produktyToolStripMenuItem.Click += new System.EventHandler(this.produktyToolStripMenuItem_Click);
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importujToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.bazaDanychToolStripMenuItem.Text = "&Baza danych";
            // 
            // importujToolStripMenuItem
            // 
            this.importujToolStripMenuItem.Name = "importujToolStripMenuItem";
            this.importujToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.importujToolStripMenuItem.Text = "&Importuj ";
            this.importujToolStripMenuItem.Click += new System.EventHandler(this.importujToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.wyczyśćToolStripMenuItem.Text = "&Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.oAutorachToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pomocToolStripMenuItem.Text = "P&omoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            // 
            // oAutorachToolStripMenuItem
            // 
            this.oAutorachToolStripMenuItem.Name = "oAutorachToolStripMenuItem";
            this.oAutorachToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oAutorachToolStripMenuItem.Text = "O Autorach";
            // 
            // backgroundThread
            // 
            this.backgroundThread.WorkerReportsProgress = true;
            this.backgroundThread.WorkerSupportsCancellation = true;
            this.backgroundThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundThread_DoWork);
            this.backgroundThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundThread_ProgressChanged);
            this.backgroundThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundThread_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 466);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(738, 23);
            this.progressBar.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(738, 433);
            this.dataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 501);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gastro";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundThread;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem zarzadzajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potrawyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
    }
}

