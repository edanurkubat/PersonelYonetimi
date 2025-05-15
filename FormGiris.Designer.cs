namespace PersonelYonetimi
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbKullanici = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGiris.Location = new System.Drawing.Point(208, 424);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 42);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbKullanici
            // 
            this.tbKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKullanici.Location = new System.Drawing.Point(229, 288);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(190, 22);
            this.tbKullanici.TabIndex = 0;
            // 
            // tbSifre
            // 
            this.tbSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSifre.Location = new System.Drawing.Point(229, 338);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(190, 22);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(58, 288);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(145, 24);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "KULLANICI ADI:";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSifre.Location = new System.Drawing.Point(141, 336);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(62, 24);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "ŞİFRE:";
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(171, 32);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(224, 216);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 506);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullanici);
            this.Controls.Add(this.btnGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.PictureBox pbUser;
    }
}

