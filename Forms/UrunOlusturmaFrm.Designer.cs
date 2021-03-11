
namespace ProjeTakipveHesaplama.Forms
{
    partial class UrunOlusturmaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunOlusturmaFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBoxUrunBasiSure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnUrunEkle = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Kodu:";
            // 
            // txtBoxUrunKodu
            // 
            this.txtBoxUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunKodu.Location = new System.Drawing.Point(324, 158);
            this.txtBoxUrunKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunKodu.Name = "txtBoxUrunKodu";
            this.txtBoxUrunKodu.Size = new System.Drawing.Size(265, 24);
            this.txtBoxUrunKodu.TabIndex = 1;
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(324, 190);
            this.txtBoxUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(265, 24);
            this.txtBoxUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Adı:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_back-alt_134226.png");
            this.ımageList1.Images.SetKeyName(1, "backArrow.png");
            // 
            // txtBoxUrunBasiSure
            // 
            this.txtBoxUrunBasiSure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxUrunBasiSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunBasiSure.Location = new System.Drawing.Point(324, 227);
            this.txtBoxUrunBasiSure.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunBasiSure.Name = "txtBoxUrunBasiSure";
            this.txtBoxUrunBasiSure.Size = new System.Drawing.Size(132, 24);
            this.txtBoxUrunBasiSure.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ürün Başına Süre(DK):";
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdet.Location = new System.Drawing.Point(324, 262);
            this.txtBoxAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(132, 24);
            this.txtBoxAdet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Adet:";
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
            this.btnGeri.TabIndex = 6;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.ButtonColor = System.Drawing.Color.White;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.Location = new System.Drawing.Point(1041, 510);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUrunEkle.Size = new System.Drawing.Size(187, 68);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // UrunOlusturmaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxUrunBasiSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxAdet);
            this.Controls.Add(this.txtBoxUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUrunKodu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunOlusturmaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Oluşturma";
            this.Load += new System.EventHandler(this.UrunOlusturmaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUrunKodu;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtBoxUrunBasiSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeri;
        private ePOSOne.btnProduct.Button_WOC btnUrunEkle;
    }
}