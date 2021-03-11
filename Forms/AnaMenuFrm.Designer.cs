
namespace ProjeTakipveHesaplama
{
    partial class AnaMenu
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
            this.anaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliEkraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblKullaniciAdi = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaleplerim = new ePOSOne.btnProduct.Button_WOC();
            this.btnSiparisListele = new ePOSOne.btnProduct.Button_WOC();
            this.btnCikis = new ePOSOne.btnProduct.Button_WOC();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anaMenuToolStripMenuItem
            // 
            this.anaMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaMenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            this.anaMenuToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.anaMenuToolStripMenuItem.Text = "Ana Menü";
            // 
            // malzemelerToolStripMenuItem
            // 
            this.malzemelerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malzemelerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.malzemelerToolStripMenuItem.Name = "malzemelerToolStripMenuItem";
            this.malzemelerToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.malzemelerToolStripMenuItem.Text = "Malzemeler";
            this.malzemelerToolStripMenuItem.Click += new System.EventHandler(this.malzemelerToolStripMenuItem_Click);
            // 
            // yetkiliEkraniToolStripMenuItem
            // 
            this.yetkiliEkraniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yetkiliEkraniToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yetkiliEkraniToolStripMenuItem.Name = "yetkiliEkraniToolStripMenuItem";
            this.yetkiliEkraniToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.yetkiliEkraniToolStripMenuItem.Text = "Yetkili Ekranı";
            this.yetkiliEkraniToolStripMenuItem.Click += new System.EventHandler(this.yetkiliEkraniToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenuToolStripMenuItem,
            this.malzemelerToolStripMenuItem,
            this.yetkiliEkraniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Depth = 0;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(150, 120);
            this.lblKullaniciAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(21, 24);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnTaleplerim
            // 
            this.btnTaleplerim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaleplerim.BackColor = System.Drawing.Color.Transparent;
            this.btnTaleplerim.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaleplerim.ButtonColor = System.Drawing.Color.White;
            this.btnTaleplerim.FlatAppearance.BorderSize = 0;
            this.btnTaleplerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaleplerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaleplerim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaleplerim.Location = new System.Drawing.Point(496, 319);
            this.btnTaleplerim.Name = "btnTaleplerim";
            this.btnTaleplerim.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaleplerim.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaleplerim.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaleplerim.Size = new System.Drawing.Size(246, 71);
            this.btnTaleplerim.TabIndex = 3;
            this.btnTaleplerim.Text = "TALEPLERİM";
            this.btnTaleplerim.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaleplerim.UseVisualStyleBackColor = false;
            this.btnTaleplerim.Click += new System.EventHandler(this.btnTaleplerim_Click);
            // 
            // btnSiparisListele
            // 
            this.btnSiparisListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiparisListele.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisListele.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisListele.ButtonColor = System.Drawing.Color.White;
            this.btnSiparisListele.FlatAppearance.BorderSize = 0;
            this.btnSiparisListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisListele.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisListele.Location = new System.Drawing.Point(496, 242);
            this.btnSiparisListele.Name = "btnSiparisListele";
            this.btnSiparisListele.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisListele.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisListele.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSiparisListele.Size = new System.Drawing.Size(246, 71);
            this.btnSiparisListele.TabIndex = 2;
            this.btnSiparisListele.Text = "SİPARİŞ LİSTELE";
            this.btnSiparisListele.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisListele.UseVisualStyleBackColor = false;
            this.btnSiparisListele.Click += new System.EventHandler(this.btnSiparisListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCikis.ButtonColor = System.Drawing.Color.White;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCikis.Location = new System.Drawing.Point(1110, 120);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCikis.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.Size = new System.Drawing.Size(118, 51);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnTaleplerim);
            this.Controls.Add(this.btnSiparisListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem anaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliEkraniToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MaterialSkin.Controls.MaterialLabel lblKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnCikis;
        private ePOSOne.btnProduct.Button_WOC btnSiparisListele;
        private ePOSOne.btnProduct.Button_WOC btnTaleplerim;
    }
}

