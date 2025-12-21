namespace WinformsKontrolleri
{
    partial class WebBrowserKontrolu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserKontrolu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Geri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ileri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Yenile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTB_Adres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TSB_Git = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Geri,
            this.TSB_Ileri,
            this.toolStripSeparator1,
            this.TSB_Yenile,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TSTB_Adres,
            this.TSB_Git,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 23);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Geri
            // 
            this.TSB_Geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Geri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Geri.Image")));
            this.TSB_Geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Geri.Name = "TSB_Geri";
            this.TSB_Geri.Size = new System.Drawing.Size(32, 19);
            this.TSB_Geri.Text = "Geri";
            this.TSB_Geri.Click += new System.EventHandler(this.TSB_Geri_Click);
            // 
            // TSB_Ileri
            // 
            this.TSB_Ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Ileri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ileri.Image")));
            this.TSB_Ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ileri.Name = "TSB_Ileri";
            this.TSB_Ileri.Size = new System.Drawing.Size(30, 19);
            this.TSB_Ileri.Text = "Ileri";
            this.TSB_Ileri.Click += new System.EventHandler(this.TSB_Ileri_Click);
            // 
            // TSB_Yenile
            // 
            this.TSB_Yenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Yenile.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Yenile.Image")));
            this.TSB_Yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Yenile.Name = "TSB_Yenile";
            this.TSB_Yenile.Size = new System.Drawing.Size(42, 19);
            this.TSB_Yenile.Text = "Yenile";
            this.TSB_Yenile.Click += new System.EventHandler(this.TSB_Yenile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // TSTB_Adres
            // 
            this.TSTB_Adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSTB_Adres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTB_Adres.Name = "TSTB_Adres";
            this.TSTB_Adres.Size = new System.Drawing.Size(500, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 15);
            this.toolStripLabel1.Text = "Adres = ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 403);
            this.webBrowser1.TabIndex = 2;
            // 
            // TSB_Git
            // 
            this.TSB_Git.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Git.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Git.Image")));
            this.TSB_Git.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Git.Name = "TSB_Git";
            this.TSB_Git.Size = new System.Drawing.Size(42, 19);
            this.TSB_Git.Text = "Git ->";
            this.TSB_Git.Click += new System.EventHandler(this.TSB_Git_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 19);
            this.toolStripButton1.Text = "Home";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // WebBrowserKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowserKontrolu";
            this.Text = "Internette Gezen Renkli Tilki";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Geri;
        private System.Windows.Forms.ToolStripButton TSB_Ileri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Yenile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TSTB_Adres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton TSB_Git;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}