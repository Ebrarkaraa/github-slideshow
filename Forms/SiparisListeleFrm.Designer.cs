
namespace ProjeTakipveHesaplama.Forms
{
    partial class Siparişler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparişler));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.btnUrunListele = new ePOSOne.btnProduct.Button_WOC();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.btnSiparisEkle = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 134);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1211, 443);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.btnGeri.TabIndex = 5;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Red;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Red;
            this.button_WOC1.Location = new System.Drawing.Point(1050, 91);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Red;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(177, 36);
            this.button_WOC1.TabIndex = 4;
            this.button_WOC1.Text = "Sipariş Sil";
            this.button_WOC1.TextColor = System.Drawing.Color.Red;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunListele.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunListele.BorderColor = System.Drawing.Color.Orange;
            this.btnUrunListele.ButtonColor = System.Drawing.Color.White;
            this.btnUrunListele.FlatAppearance.BorderSize = 0;
            this.btnUrunListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunListele.ForeColor = System.Drawing.Color.Orange;
            this.btnUrunListele.Location = new System.Drawing.Point(867, 91);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnUrunListele.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnUrunListele.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUrunListele.Size = new System.Drawing.Size(177, 36);
            this.btnUrunListele.TabIndex = 3;
            this.btnUrunListele.Text = "Ürünleri Listele";
            this.btnUrunListele.TextColor = System.Drawing.Color.Orange;
            this.btnUrunListele.UseVisualStyleBackColor = false;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.ButtonColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(684, 91);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(177, 36);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Sipariş Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.ButtonColor = System.Drawing.Color.White;
            this.btnSiparisEkle.FlatAppearance.BorderSize = 0;
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.Location = new System.Drawing.Point(501, 91);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Size = new System.Drawing.Size(177, 36);
            this.btnSiparisEkle.TabIndex = 1;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // Siparişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.btnUrunListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listView1);
            this.Name = "Siparişler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.SiparisListeleFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private ePOSOne.btnProduct.Button_WOC btnSiparisEkle;
        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private ePOSOne.btnProduct.Button_WOC btnUrunListele;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}