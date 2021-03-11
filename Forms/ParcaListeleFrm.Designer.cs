
namespace ProjeTakipveHesaplama.Forms
{
    partial class ParcaListeleFrm
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.urunlertoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urunAyrıntıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new ePOSOne.btnProduct.Button_WOC();
            this.btnAyrintiGoster = new ePOSOne.btnProduct.Button_WOC();
            this.btnParcaEkle = new ePOSOne.btnProduct.Button_WOC();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(105, 145);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(0, 17);
            this.lblUrunAdi.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ürün Adı:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 164);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1214, 413);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.urunlertoolStripMenuItem1,
            this.urunAyrıntıToolStripMenuItem,
            this.parcalarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 78);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1240, 31);
            this.menuStrip2.TabIndex = 60;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // urunlertoolStripMenuItem1
            // 
            this.urunlertoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunlertoolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunlertoolStripMenuItem1.Name = "urunlertoolStripMenuItem1";
            this.urunlertoolStripMenuItem1.Size = new System.Drawing.Size(81, 27);
            this.urunlertoolStripMenuItem1.Text = "Ürünler";
            this.urunlertoolStripMenuItem1.Click += new System.EventHandler(this.UrunlerToolStripMenuItem_Click);
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
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BorderColor = System.Drawing.Color.Red;
            this.btnSil.ButtonColor = System.Drawing.Color.White;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(1050, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(177, 36);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Parça Sil";
            this.btnSil.TextColor = System.Drawing.Color.Red;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAyrintiGoster
            // 
            this.btnAyrintiGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyrintiGoster.BackColor = System.Drawing.Color.Transparent;
            this.btnAyrintiGoster.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.ButtonColor = System.Drawing.Color.White;
            this.btnAyrintiGoster.FlatAppearance.BorderSize = 0;
            this.btnAyrintiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyrintiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyrintiGoster.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.Location = new System.Drawing.Point(867, 121);
            this.btnAyrintiGoster.Name = "btnAyrintiGoster";
            this.btnAyrintiGoster.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAyrintiGoster.Size = new System.Drawing.Size(177, 36);
            this.btnAyrintiGoster.TabIndex = 2;
            this.btnAyrintiGoster.Text = "Parça Bilgileri";
            this.btnAyrintiGoster.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.UseVisualStyleBackColor = false;
            this.btnAyrintiGoster.Click += new System.EventHandler(this.btnAyrintiGoster_Click);
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParcaEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnParcaEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.ButtonColor = System.Drawing.Color.White;
            this.btnParcaEkle.FlatAppearance.BorderSize = 0;
            this.btnParcaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcaEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.Location = new System.Drawing.Point(684, 121);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParcaEkle.Size = new System.Drawing.Size(177, 36);
            this.btnParcaEkle.TabIndex = 1;
            this.btnParcaEkle.Text = "Parça Ekle";
            this.btnParcaEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnParcaEkle.UseVisualStyleBackColor = false;
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // ParcaListeleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAyrintiGoster);
            this.Controls.Add(this.btnParcaEkle);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ParcaListeleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parçalar";
            this.Load += new System.EventHandler(this.ParcaListeleFrm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem urunlertoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urunAyrıntıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcalarToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC btnSil;
        private ePOSOne.btnProduct.Button_WOC btnAyrintiGoster;
        private ePOSOne.btnProduct.Button_WOC btnParcaEkle;
    }
}