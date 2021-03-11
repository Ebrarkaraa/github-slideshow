
namespace ProjeTakipveHesaplama.Forms
{
    partial class UrunListelemeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunListelemeFrm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSil = new ePOSOne.btnProduct.Button_WOC();
            this.btnAyrintiGoster = new ePOSOne.btnProduct.Button_WOC();
            this.btnUrunEkle = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 155);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1211, 420);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sipariş Adı:";
            // 
            // lblSiparisAdi
            // 
            this.lblSiparisAdi.AutoSize = true;
            this.lblSiparisAdi.Location = new System.Drawing.Point(118, 138);
            this.lblSiparisAdi.Name = "lblSiparisAdi";
            this.lblSiparisAdi.Size = new System.Drawing.Size(0, 17);
            this.lblSiparisAdi.TabIndex = 30;
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
            this.btnGeri.TabIndex = 57;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
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
            this.btnSil.Location = new System.Drawing.Point(1051, 112);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(177, 36);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Ürün Sil";
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
            this.btnAyrintiGoster.Location = new System.Drawing.Point(868, 112);
            this.btnAyrintiGoster.Name = "btnAyrintiGoster";
            this.btnAyrintiGoster.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAyrintiGoster.Size = new System.Drawing.Size(177, 36);
            this.btnAyrintiGoster.TabIndex = 2;
            this.btnAyrintiGoster.Text = "Ürün Bilgileri";
            this.btnAyrintiGoster.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnAyrintiGoster.UseVisualStyleBackColor = false;
            this.btnAyrintiGoster.Click += new System.EventHandler(this.btnAyrintiGoster_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.ButtonColor = System.Drawing.Color.White;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.Location = new System.Drawing.Point(685, 112);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUrunEkle.Size = new System.Drawing.Size(177, 36);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // UrunListelemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAyrintiGoster);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblSiparisAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunListelemeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.ProjeListelemeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiparisAdi;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private ePOSOne.btnProduct.Button_WOC btnSil;
        private ePOSOne.btnProduct.Button_WOC btnAyrintiGoster;
        private ePOSOne.btnProduct.Button_WOC btnUrunEkle;
    }
}