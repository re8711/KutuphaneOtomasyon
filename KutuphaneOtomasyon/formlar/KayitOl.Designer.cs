namespace KutuphaneOtomasyon.formlar
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kayıt Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-Posta:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(145, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(217, 20);
            this.txtAd.TabIndex = 6;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_YaziGirisKontrol);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(145, 47);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtSoyad.TabIndex = 9;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_YaziGirisKontrol);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(145, 85);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(217, 20);
            this.txtEposta.TabIndex = 10;
            this.txtEposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEposta_KeyPress);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(270, 232);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayitOl.TabIndex = 11;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Location = new System.Drawing.Point(145, 157);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(217, 20);
            this.dtpKayitTarihi.TabIndex = 12;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(135, 232);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(145, 123);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(217, 20);
            this.txtSifre.TabIndex = 15;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(21, 193);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(34, 13);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "bilgi: -";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpKayitTarihi);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.btnKayitOl);
            this.panel1.Controls.Add(this.txtEposta);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 307);
            this.panel1.TabIndex = 17;
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 331);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.KayitOl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
    }
}