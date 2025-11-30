namespace WinformsKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.cb_dersler = new System.Windows.Forms.ComboBox();
            this.btn_dersSec = new System.Windows.Forms.Button();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_sec = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dersAdi = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_sec.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Seçiniz";
            // 
            // cb_dersler
            // 
            this.cb_dersler.FormattingEnabled = true;
            this.cb_dersler.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Tarih",
            "Edebiyat",
            "Kimya",
            "Karete",
            "Coğrafya",
            "Beden",
            "Yazılım"});
            this.cb_dersler.Location = new System.Drawing.Point(84, 19);
            this.cb_dersler.Name = "cb_dersler";
            this.cb_dersler.Size = new System.Drawing.Size(186, 21);
            this.cb_dersler.TabIndex = 1;
            this.cb_dersler.SelectedIndexChanged += new System.EventHandler(this.cb_dersler_SelectedIndexChanged);
            // 
            // btn_dersSec
            // 
            this.btn_dersSec.Location = new System.Drawing.Point(195, 46);
            this.btn_dersSec.Name = "btn_dersSec";
            this.btn_dersSec.Size = new System.Drawing.Size(75, 23);
            this.btn_dersSec.TabIndex = 2;
            this.btn_dersSec.Text = "Ders Seç";
            this.btn_dersSec.UseVisualStyleBackColor = true;
            this.btn_dersSec.Click += new System.EventHandler(this.btn_dersSec_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Location = new System.Drawing.Point(12, 75);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(76, 13);
            this.lbl_secilen.TabIndex = 3;
            this.lbl_secilen.Text = "Seçilen Ders =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.tb_dersAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekle";
            // 
            // gb_sec
            // 
            this.gb_sec.Controls.Add(this.cb_dersler);
            this.gb_sec.Controls.Add(this.lbl_secilen);
            this.gb_sec.Controls.Add(this.btn_dersSec);
            this.gb_sec.Controls.Add(this.label1);
            this.gb_sec.Location = new System.Drawing.Point(12, 121);
            this.gb_sec.Name = "gb_sec";
            this.gb_sec.Size = new System.Drawing.Size(283, 110);
            this.gb_sec.TabIndex = 5;
            this.gb_sec.TabStop = false;
            this.gb_sec.Text = "Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders Adı =";
            // 
            // tb_dersAdi
            // 
            this.tb_dersAdi.Location = new System.Drawing.Point(84, 25);
            this.tb_dersAdi.Name = "tb_dersAdi";
            this.tb_dersAdi.Size = new System.Drawing.Size(186, 20);
            this.tb_dersAdi.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(195, 51);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ders Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 242);
            this.Controls.Add(this.gb_sec);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_sec.ResumeLayout(false);
            this.gb_sec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_dersler;
        private System.Windows.Forms.Button btn_dersSec;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_dersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_sec;
    }
}