
namespace ProjeTakipveHesaplama.Forms
{
    partial class GirisKontrolFrm
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
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.lnkLblKayitOlustur = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.chckBoxBeniHatirla = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnGirisYap = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(255, 129);
            this.txtBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(158, 34);
            this.txtBoxKullaniciAdi.TabIndex = 1;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxSifre.Location = new System.Drawing.Point(255, 171);
            this.txtBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.PasswordChar = '*';
            this.txtBoxSifre.Size = new System.Drawing.Size(158, 34);
            this.txtBoxSifre.TabIndex = 2;
            // 
            // lnkLblKayitOlustur
            // 
            this.lnkLblKayitOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLblKayitOlustur.AutoSize = true;
            this.lnkLblKayitOlustur.BackColor = System.Drawing.Color.White;
            this.lnkLblKayitOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblKayitOlustur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkLblKayitOlustur.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkLblKayitOlustur.Location = new System.Drawing.Point(286, 303);
            this.lnkLblKayitOlustur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLblKayitOlustur.Name = "lnkLblKayitOlustur";
            this.lnkLblKayitOlustur.Size = new System.Drawing.Size(106, 20);
            this.lnkLblKayitOlustur.TabIndex = 4;
            this.lnkLblKayitOlustur.TabStop = true;
            this.lnkLblKayitOlustur.Text = "Kayıt Oluştur";
            this.lnkLblKayitOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblKayitOlustur_LinkClicked);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(128, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(120, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Kullanıcı Adı:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(128, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 24);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Şifre:";
            // 
            // chckBoxBeniHatirla
            // 
            this.chckBoxBeniHatirla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBoxBeniHatirla.AutoSize = true;
            this.chckBoxBeniHatirla.BackColor = System.Drawing.Color.White;
            this.chckBoxBeniHatirla.Depth = 0;
            this.chckBoxBeniHatirla.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBoxBeniHatirla.Location = new System.Drawing.Point(270, 209);
            this.chckBoxBeniHatirla.Margin = new System.Windows.Forms.Padding(0);
            this.chckBoxBeniHatirla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBoxBeniHatirla.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBoxBeniHatirla.Name = "chckBoxBeniHatirla";
            this.chckBoxBeniHatirla.Ripple = true;
            this.chckBoxBeniHatirla.Size = new System.Drawing.Size(121, 30);
            this.chckBoxBeniHatirla.TabIndex = 11;
            this.chckBoxBeniHatirla.Text = "Beni Hatırla";
            this.chckBoxBeniHatirla.UseVisualStyleBackColor = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGirisYap.ButtonColor = System.Drawing.Color.White;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(255, 245);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGirisYap.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGirisYap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGirisYap.Size = new System.Drawing.Size(158, 43);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // GirisKontrolFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.chckBoxBeniHatirla);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lnkLblKayitOlustur);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 390);
            this.Name = "GirisKontrolFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş ";
            this.Load += new System.EventHandler(this.GirisKontrolFrm_Load);
            this.Enter += new System.EventHandler(this.btnGirisYap_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.LinkLabel lnkLblKayitOlustur;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox chckBoxBeniHatirla;
        private ePOSOne.btnProduct.Button_WOC btnGirisYap;
    }
}