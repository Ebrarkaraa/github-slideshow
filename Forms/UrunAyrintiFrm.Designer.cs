
namespace ProjeTakipveHesaplama.Forms
{
    partial class UrunAyrintiFrm
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
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.txtBoxUrunBasiSure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxToplamMaliyet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunAyrıntıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdet.Location = new System.Drawing.Point(282, 278);
            this.txtBoxAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(132, 24);
            this.txtBoxAdet.TabIndex = 4;
            this.txtBoxAdet.TextChanged += new System.EventHandler(this.txtBoxAdet_TextChanged);
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(282, 206);
            this.txtBoxUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(265, 24);
            this.txtBoxUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtBoxUrunKodu
            // 
            this.txtBoxUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunKodu.Location = new System.Drawing.Point(282, 173);
            this.txtBoxUrunKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunKodu.Name = "txtBoxUrunKodu";
            this.txtBoxUrunKodu.Size = new System.Drawing.Size(265, 24);
            this.txtBoxUrunKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Kodu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ürün ID:";
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunID.Location = new System.Drawing.Point(277, 138);
            this.lblUrunID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(0, 25);
            this.lblUrunID.TabIndex = 40;
            // 
            // txtBoxUrunBasiSure
            // 
            this.txtBoxUrunBasiSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUrunBasiSure.Location = new System.Drawing.Point(282, 242);
            this.txtBoxUrunBasiSure.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUrunBasiSure.Name = "txtBoxUrunBasiSure";
            this.txtBoxUrunBasiSure.Size = new System.Drawing.Size(132, 24);
            this.txtBoxUrunBasiSure.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ürün Başına Süre(DK):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adet:";
            // 
            // txtBoxToplamMaliyet
            // 
            this.txtBoxToplamMaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxToplamMaliyet.Location = new System.Drawing.Point(283, 316);
            this.txtBoxToplamMaliyet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxToplamMaliyet.Name = "txtBoxToplamMaliyet";
            this.txtBoxToplamMaliyet.Size = new System.Drawing.Size(132, 24);
            this.txtBoxToplamMaliyet.TabIndex = 5;
            this.txtBoxToplamMaliyet.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Toplam Maliyeti:";
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
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Sipariş Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunlerToolStripMenuItem,
            this.urunAyrıntıToolStripMenuItem,
            this.parcalarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 78);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1240, 31);
            this.menuStrip2.TabIndex = 59;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunlerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.urunlerToolStripMenuItem.Text = "Ürünler";
            this.urunlerToolStripMenuItem.Click += new System.EventHandler(this.urunlerToolStripMenuItem_Click);
            // 
            // urunAyrıntıToolStripMenuItem
            // 
            this.urunAyrıntıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunAyrıntıToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunAyrıntıToolStripMenuItem.Name = "urunAyrıntıToolStripMenuItem";
            this.urunAyrıntıToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.urunAyrıntıToolStripMenuItem.Text = "Ürün Ayrıntı";
            this.urunAyrıntıToolStripMenuItem.Click += new System.EventHandler(this.ürünAyrıntıToolStripMenuItem_Click);
            // 
            // parcalarToolStripMenuItem
            // 
            this.parcalarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.parcalarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parcalarToolStripMenuItem.Name = "parcalarToolStripMenuItem";
            this.parcalarToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.parcalarToolStripMenuItem.Text = "Parçalar";
            this.parcalarToolStripMenuItem.Click += new System.EventHandler(this.parçalarToolStripMenuItem_Click);
            // 
            // UrunAyrintiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtBoxToplamMaliyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxUrunBasiSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUrunKodu);
            this.Controls.Add(this.label1);
            this.Name = "UrunAyrintiFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelleme";
            this.Load += new System.EventHandler(this.ProjeAyrintiFrm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUrunKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.TextBox txtBoxUrunBasiSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxToplamMaliyet;
        private System.Windows.Forms.Label label7;
        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunAyrıntıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcalarToolStripMenuItem;
    }
}