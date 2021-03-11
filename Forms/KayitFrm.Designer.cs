
namespace ProjeTakipveHesaplama.Forms
{
    partial class KayitFrm
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
            this.lnkLblKaydimVar = new System.Windows.Forms.LinkLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lnkLblKaydimVar
            // 
            this.lnkLblKaydimVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLblKaydimVar.AutoSize = true;
            this.lnkLblKaydimVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lnkLblKaydimVar.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkLblKaydimVar.Location = new System.Drawing.Point(274, 266);
            this.lnkLblKaydimVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLblKaydimVar.Name = "lnkLblKaydimVar";
            this.lnkLblKaydimVar.Size = new System.Drawing.Size(141, 20);
            this.lnkLblKaydimVar.TabIndex = 4;
            this.lnkLblKaydimVar.TabStop = true;
            this.lnkLblKaydimVar.Text = "Zaten Kaydım Var";
            this.lnkLblKaydimVar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblKaydimVar_LinkClicked);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(76, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 24);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Şifre:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(76, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(120, 24);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Kullanıcı Adı:";
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(255, 129);
            this.txtBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(158, 34);
            this.txtBoxKullaniciAdi.TabIndex = 1;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSifre.Location = new System.Drawing.Point(255, 171);
            this.txtBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.PasswordChar = '*';
            this.txtBoxSifre.Size = new System.Drawing.Size(158, 34);
            this.txtBoxSifre.TabIndex = 2;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.btnKayitOl.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitOl.ButtonColor = System.Drawing.Color.White;
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitOl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitOl.Location = new System.Drawing.Point(255, 212);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitOl.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitOl.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKayitOl.Size = new System.Drawing.Size(158, 43);
            this.btnKayitOl.TabIndex = 3;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // KayitFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lnkLblKaydimVar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 390);
            this.Name = "KayitFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.KayitFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLblKaydimVar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private ePOSOne.btnProduct.Button_WOC btnKayitOl;
    }
}