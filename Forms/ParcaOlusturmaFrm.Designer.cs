
namespace ProjeTakipveHesaplama
{
    partial class HesaplamaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesaplamaFrm));
            this.chckBoxBoya = new System.Windows.Forms.CheckBox();
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtBoxBoy = new System.Windows.Forms.TextBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtBoxEn = new System.Windows.Forms.TextBox();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblMalzemeTuru = new System.Windows.Forms.Label();
            this.cmbBoxMalzemeTuru = new System.Windows.Forms.ComboBox();
            this.cmbBoxBoya = new System.Windows.Forms.ComboBox();
            this.cmbBoxMalzemeAdi = new System.Windows.Forms.ComboBox();
            this.lblMalzemeSec = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnParcaEkle = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // chckBoxBoya
            // 
            this.chckBoxBoya.AutoSize = true;
            this.chckBoxBoya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxBoya.Location = new System.Drawing.Point(437, 223);
            this.chckBoxBoya.Margin = new System.Windows.Forms.Padding(4);
            this.chckBoxBoya.Name = "chckBoxBoya";
            this.chckBoxBoya.Size = new System.Drawing.Size(66, 21);
            this.chckBoxBoya.TabIndex = 23;
            this.chckBoxBoya.Text = "Boya";
            this.chckBoxBoya.UseVisualStyleBackColor = true;
            this.chckBoxBoya.CheckedChanged += new System.EventHandler(this.chckBoxLake_CheckedChanged);
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdet.Location = new System.Drawing.Point(562, 270);
            this.txtBoxAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(132, 26);
            this.txtBoxAdet.TabIndex = 4;
            this.txtBoxAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAdet_KeyPress);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdet.Location = new System.Drawing.Point(434, 276);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(46, 17);
            this.lblAdet.TabIndex = 26;
            this.lblAdet.Text = "Adet:";
            // 
            // txtBoxBoy
            // 
            this.txtBoxBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBoy.Location = new System.Drawing.Point(196, 270);
            this.txtBoxBoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBoy.Name = "txtBoxBoy";
            this.txtBoxBoy.Size = new System.Drawing.Size(132, 26);
            this.txtBoxBoy.TabIndex = 2;
            this.txtBoxBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBoy_KeyPress);
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoy.Location = new System.Drawing.Point(68, 274);
            this.lblBoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(118, 17);
            this.lblBoy.TabIndex = 20;
            this.lblBoy.Text = "Parçanın Boyu:";
            // 
            // txtBoxEn
            // 
            this.txtBoxEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEn.Location = new System.Drawing.Point(196, 218);
            this.txtBoxEn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEn.Name = "txtBoxEn";
            this.txtBoxEn.Size = new System.Drawing.Size(132, 26);
            this.txtBoxEn.TabIndex = 1;
            this.txtBoxEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEn_KeyPress);
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.Location = new System.Drawing.Point(68, 224);
            this.lblEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(105, 17);
            this.lblEn.TabIndex = 18;
            this.lblEn.Text = "Parçanın Eni:";
            // 
            // lblMalzemeTuru
            // 
            this.lblMalzemeTuru.AutoSize = true;
            this.lblMalzemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalzemeTuru.Location = new System.Drawing.Point(68, 173);
            this.lblMalzemeTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalzemeTuru.Name = "lblMalzemeTuru";
            this.lblMalzemeTuru.Size = new System.Drawing.Size(115, 17);
            this.lblMalzemeTuru.TabIndex = 17;
            this.lblMalzemeTuru.Text = "Malzeme Türü:";
            // 
            // cmbBoxMalzemeTuru
            // 
            this.cmbBoxMalzemeTuru.DropDownHeight = 200;
            this.cmbBoxMalzemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMalzemeTuru.FormattingEnabled = true;
            this.cmbBoxMalzemeTuru.IntegralHeight = false;
            this.cmbBoxMalzemeTuru.Location = new System.Drawing.Point(196, 172);
            this.cmbBoxMalzemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeTuru.Name = "cmbBoxMalzemeTuru";
            this.cmbBoxMalzemeTuru.Size = new System.Drawing.Size(171, 24);
            this.cmbBoxMalzemeTuru.TabIndex = 32;
            this.cmbBoxMalzemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMalzemeTuru_SelectedIndexChanged);
            // 
            // cmbBoxBoya
            // 
            this.cmbBoxBoya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBoya.Enabled = false;
            this.cmbBoxBoya.FormattingEnabled = true;
            this.cmbBoxBoya.Items.AddRange(new object[] {
            "TEK YÜZ",
            "ÇİFT YÜZ"});
            this.cmbBoxBoya.Location = new System.Drawing.Point(562, 220);
            this.cmbBoxBoya.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxBoya.Name = "cmbBoxBoya";
            this.cmbBoxBoya.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxBoya.TabIndex = 24;
            // 
            // cmbBoxMalzemeAdi
            // 
            this.cmbBoxMalzemeAdi.DropDownHeight = 200;
            this.cmbBoxMalzemeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMalzemeAdi.FormattingEnabled = true;
            this.cmbBoxMalzemeAdi.IntegralHeight = false;
            this.cmbBoxMalzemeAdi.Location = new System.Drawing.Point(562, 172);
            this.cmbBoxMalzemeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeAdi.Name = "cmbBoxMalzemeAdi";
            this.cmbBoxMalzemeAdi.Size = new System.Drawing.Size(171, 24);
            this.cmbBoxMalzemeAdi.TabIndex = 53;
            this.cmbBoxMalzemeAdi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMalzemeAdi_SelectedIndexChanged);
            // 
            // lblMalzemeSec
            // 
            this.lblMalzemeSec.AutoSize = true;
            this.lblMalzemeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalzemeSec.Location = new System.Drawing.Point(434, 173);
            this.lblMalzemeSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalzemeSec.Name = "lblMalzemeSec";
            this.lblMalzemeSec.Size = new System.Drawing.Size(104, 17);
            this.lblMalzemeSec.TabIndex = 52;
            this.lblMalzemeSec.Text = "Malzeme Adı:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_back-alt_134226.png");
            this.ımageList1.Images.SetKeyName(1, "backArrow.png");
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
            this.btnGeri.TabIndex = 58;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParcaEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnParcaEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.ButtonColor = System.Drawing.Color.White;
            this.btnParcaEkle.FlatAppearance.BorderSize = 0;
            this.btnParcaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcaEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.Location = new System.Drawing.Point(1041, 510);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParcaEkle.Size = new System.Drawing.Size(187, 68);
            this.btnParcaEkle.TabIndex = 59;
            this.btnParcaEkle.Text = "Parça Ekle";
            this.btnParcaEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.UseVisualStyleBackColor = false;
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // HesaplamaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnParcaEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbBoxMalzemeAdi);
            this.Controls.Add(this.lblMalzemeSec);
            this.Controls.Add(this.cmbBoxBoya);
            this.Controls.Add(this.cmbBoxMalzemeTuru);
            this.Controls.Add(this.chckBoxBoya);
            this.Controls.Add(this.txtBoxAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtBoxBoy);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.txtBoxEn);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblMalzemeTuru);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesaplamaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parça Oluşturma";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chckBoxBoya;
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtBoxBoy;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtBoxEn;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblMalzemeTuru;
        private System.Windows.Forms.ComboBox cmbBoxMalzemeTuru;
        private System.Windows.Forms.ComboBox cmbBoxBoya;
        private System.Windows.Forms.ComboBox cmbBoxMalzemeAdi;
        private System.Windows.Forms.Label lblMalzemeSec;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private ePOSOne.btnProduct.Button_WOC btnParcaEkle;
    }
}