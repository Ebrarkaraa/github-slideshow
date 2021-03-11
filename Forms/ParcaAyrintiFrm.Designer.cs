
namespace ProjeTakipveHesaplama.Forms
{
    partial class ParcaAyrintiFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcaAyrintiFrm));
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblParcaId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEn = new System.Windows.Forms.TextBox();
            this.txtBoxBoy = new System.Windows.Forms.TextBox();
            this.txtBoxParcaAdeti = new System.Windows.Forms.TextBox();
            this.lblUrunAdiKodu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSiparisAdiKodu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxParcaMaliyeti = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBoxBoya = new System.Windows.Forms.ComboBox();
            this.chckBoxBoya = new System.Windows.Forms.CheckBox();
            this.cmbBoxMalzemeTuru = new System.Windows.Forms.ComboBox();
            this.cmbBoxMalzemeAdi = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.txtBoxToplamParcaMaliyeti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.ImageKey = "backArrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(0, 78);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(52, 53);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "backArrow.png");
            // 
            // lblParcaId
            // 
            this.lblParcaId.AutoSize = true;
            this.lblParcaId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcaId.Location = new System.Drawing.Point(308, 223);
            this.lblParcaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcaId.Name = "lblParcaId";
            this.lblParcaId.Size = new System.Drawing.Size(0, 23);
            this.lblParcaId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "Parça ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "Parça Adeti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Malzeme Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Malzeme Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Boy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "En:";
            // 
            // txtBoxEn
            // 
            this.txtBoxEn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEn.Location = new System.Drawing.Point(826, 225);
            this.txtBoxEn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEn.Name = "txtBoxEn";
            this.txtBoxEn.Size = new System.Drawing.Size(265, 28);
            this.txtBoxEn.TabIndex = 4;
            this.txtBoxEn.TextChanged += new System.EventHandler(this.parcaMaliyetHesapla);
            // 
            // txtBoxBoy
            // 
            this.txtBoxBoy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBoy.Location = new System.Drawing.Point(826, 265);
            this.txtBoxBoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBoy.Name = "txtBoxBoy";
            this.txtBoxBoy.Size = new System.Drawing.Size(265, 28);
            this.txtBoxBoy.TabIndex = 5;
            this.txtBoxBoy.TextChanged += new System.EventHandler(this.parcaMaliyetHesapla);
            // 
            // txtBoxParcaAdeti
            // 
            this.txtBoxParcaAdeti.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxParcaAdeti.Location = new System.Drawing.Point(826, 348);
            this.txtBoxParcaAdeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxParcaAdeti.Name = "txtBoxParcaAdeti";
            this.txtBoxParcaAdeti.Size = new System.Drawing.Size(265, 28);
            this.txtBoxParcaAdeti.TabIndex = 7;
            this.txtBoxParcaAdeti.Text = "0";
            this.txtBoxParcaAdeti.TextChanged += new System.EventHandler(this.parcaMaliyetHesapla);
            // 
            // lblUrunAdiKodu
            // 
            this.lblUrunAdiKodu.AutoSize = true;
            this.lblUrunAdiKodu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAdiKodu.Location = new System.Drawing.Point(308, 183);
            this.lblUrunAdiKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunAdiKodu.Name = "lblUrunAdiKodu";
            this.lblUrunAdiKodu.Size = new System.Drawing.Size(0, 23);
            this.lblUrunAdiKodu.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ürün Adı/Kodu:";
            // 
            // lblSiparisAdiKodu
            // 
            this.lblSiparisAdiKodu.AutoSize = true;
            this.lblSiparisAdiKodu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiparisAdiKodu.Location = new System.Drawing.Point(308, 143);
            this.lblSiparisAdiKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiparisAdiKodu.Name = "lblSiparisAdiKodu";
            this.lblSiparisAdiKodu.Size = new System.Drawing.Size(0, 23);
            this.lblSiparisAdiKodu.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 76;
            this.label11.Text = "Sipariş Adı/Kodu:";
            // 
            // txtBoxParcaMaliyeti
            // 
            this.txtBoxParcaMaliyeti.Enabled = false;
            this.txtBoxParcaMaliyeti.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxParcaMaliyeti.Location = new System.Drawing.Point(313, 345);
            this.txtBoxParcaMaliyeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxParcaMaliyeti.Name = "txtBoxParcaMaliyeti";
            this.txtBoxParcaMaliyeti.Size = new System.Drawing.Size(265, 28);
            this.txtBoxParcaMaliyeti.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 345);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 25);
            this.label14.TabIndex = 89;
            this.label14.Text = "Bir Parçanın Maliyeti:";
            // 
            // cmbBoxBoya
            // 
            this.cmbBoxBoya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBoya.Enabled = false;
            this.cmbBoxBoya.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBoya.FormattingEnabled = true;
            this.cmbBoxBoya.Items.AddRange(new object[] {
            "TEK YÜZ",
            "ÇİFT YÜZ"});
            this.cmbBoxBoya.Location = new System.Drawing.Point(826, 304);
            this.cmbBoxBoya.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxBoya.Name = "cmbBoxBoya";
            this.cmbBoxBoya.Size = new System.Drawing.Size(228, 29);
            this.cmbBoxBoya.TabIndex = 6;
            // 
            // chckBoxBoya
            // 
            this.chckBoxBoya.AutoSize = true;
            this.chckBoxBoya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxBoya.Location = new System.Drawing.Point(643, 303);
            this.chckBoxBoya.Margin = new System.Windows.Forms.Padding(4);
            this.chckBoxBoya.Name = "chckBoxBoya";
            this.chckBoxBoya.Size = new System.Drawing.Size(83, 29);
            this.chckBoxBoya.TabIndex = 90;
            this.chckBoxBoya.Text = "Boya";
            this.chckBoxBoya.UseVisualStyleBackColor = true;
            this.chckBoxBoya.CheckedChanged += new System.EventHandler(this.chckBoxBoya_CheckedChanged);
            // 
            // cmbBoxMalzemeTuru
            // 
            this.cmbBoxMalzemeTuru.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxMalzemeTuru.FormattingEnabled = true;
            this.cmbBoxMalzemeTuru.Location = new System.Drawing.Point(312, 263);
            this.cmbBoxMalzemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeTuru.Name = "cmbBoxMalzemeTuru";
            this.cmbBoxMalzemeTuru.Size = new System.Drawing.Size(228, 29);
            this.cmbBoxMalzemeTuru.TabIndex = 1;
            this.cmbBoxMalzemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMalzemeTuru_SelectedIndexChanged);
            // 
            // cmbBoxMalzemeAdi
            // 
            this.cmbBoxMalzemeAdi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxMalzemeAdi.FormattingEnabled = true;
            this.cmbBoxMalzemeAdi.Location = new System.Drawing.Point(312, 303);
            this.cmbBoxMalzemeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeAdi.Name = "cmbBoxMalzemeAdi";
            this.cmbBoxMalzemeAdi.Size = new System.Drawing.Size(228, 29);
            this.cmbBoxMalzemeAdi.TabIndex = 2;
            this.cmbBoxMalzemeAdi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMalzemeAdi_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.ButtonColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(1041, 510);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(187, 68);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Sipariş Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtBoxToplamParcaMaliyeti
            // 
            this.txtBoxToplamParcaMaliyeti.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxToplamParcaMaliyeti.Location = new System.Drawing.Point(313, 387);
            this.txtBoxToplamParcaMaliyeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxToplamParcaMaliyeti.Name = "txtBoxToplamParcaMaliyeti";
            this.txtBoxToplamParcaMaliyeti.Size = new System.Drawing.Size(265, 28);
            this.txtBoxToplamParcaMaliyeti.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Toplam Parça Maliyeti:";
            // 
            // ParcaAyrintiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.txtBoxToplamParcaMaliyeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxMalzemeAdi);
            this.Controls.Add(this.cmbBoxMalzemeTuru);
            this.Controls.Add(this.cmbBoxBoya);
            this.Controls.Add(this.chckBoxBoya);
            this.Controls.Add(this.txtBoxParcaMaliyeti);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSiparisAdiKodu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUrunAdiKodu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxParcaAdeti);
            this.Controls.Add(this.txtBoxBoy);
            this.Controls.Add(this.txtBoxEn);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblParcaId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ParcaAyrintiFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parça Güncelleme";
            this.Load += new System.EventHandler(this.ParcaAyrintiFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblParcaId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtBoxEn;
        private System.Windows.Forms.TextBox txtBoxBoy;
        private System.Windows.Forms.TextBox txtBoxParcaAdeti;
        private System.Windows.Forms.Label lblUrunAdiKodu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSiparisAdiKodu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxParcaMaliyeti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbBoxBoya;
        private System.Windows.Forms.CheckBox chckBoxBoya;
        private System.Windows.Forms.ComboBox cmbBoxMalzemeTuru;
        private System.Windows.Forms.ComboBox cmbBoxMalzemeAdi;
        private System.Windows.Forms.TextBox txtBoxToplamParcaMaliyeti;
        private System.Windows.Forms.Label label5;
    }
}