
namespace ProjeTakipveHesaplama.Forms
{
    partial class TalepOlusturmaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalepOlusturmaFrm));
            this.txtBoxTalepAciklamasi = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxMalzemeTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTalepGonder = new ePOSOne.btnProduct.Button_WOC();
            this.btnTalepSil = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtBoxTalepAciklamasi
            // 
            this.txtBoxTalepAciklamasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTalepAciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTalepAciklamasi.Location = new System.Drawing.Point(17, 138);
            this.txtBoxTalepAciklamasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTalepAciklamasi.Multiline = true;
            this.txtBoxTalepAciklamasi.Name = "txtBoxTalepAciklamasi";
            this.txtBoxTalepAciklamasi.Size = new System.Drawing.Size(1210, 154);
            this.txtBoxTalepAciklamasi.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 336);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1214, 241);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Önceki Talepleriniz:";
            // 
            // cmbBoxMalzemeTuru
            // 
            this.cmbBoxMalzemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMalzemeTuru.FormattingEnabled = true;
            this.cmbBoxMalzemeTuru.Location = new System.Drawing.Point(240, 110);
            this.cmbBoxMalzemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeTuru.Name = "cmbBoxMalzemeTuru";
            this.cmbBoxMalzemeTuru.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxMalzemeTuru.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Malzeme Türü:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_back-alt_134226.png");
            this.ımageList1.Images.SetKeyName(1, "backArrow.png");
            this.ımageList1.Images.SetKeyName(2, "8TG6aExzc.png");
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
            this.btnGeri.TabIndex = 36;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTalepGonder
            // 
            this.btnTalepGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalepGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnTalepGonder.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnTalepGonder.ButtonColor = System.Drawing.Color.White;
            this.btnTalepGonder.FlatAppearance.BorderSize = 0;
            this.btnTalepGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalepGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalepGonder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTalepGonder.Location = new System.Drawing.Point(867, 296);
            this.btnTalepGonder.Name = "btnTalepGonder";
            this.btnTalepGonder.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnTalepGonder.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnTalepGonder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTalepGonder.Size = new System.Drawing.Size(177, 36);
            this.btnTalepGonder.TabIndex = 2;
            this.btnTalepGonder.Text = "Talep Gönder";
            this.btnTalepGonder.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnTalepGonder.UseVisualStyleBackColor = false;
            this.btnTalepGonder.Click += new System.EventHandler(this.btnTalepGonder_Click);
            // 
            // btnTalepSil
            // 
            this.btnTalepSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalepSil.BackColor = System.Drawing.Color.Transparent;
            this.btnTalepSil.BorderColor = System.Drawing.Color.Red;
            this.btnTalepSil.ButtonColor = System.Drawing.Color.White;
            this.btnTalepSil.FlatAppearance.BorderSize = 0;
            this.btnTalepSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalepSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalepSil.ForeColor = System.Drawing.Color.Red;
            this.btnTalepSil.Location = new System.Drawing.Point(1050, 296);
            this.btnTalepSil.Name = "btnTalepSil";
            this.btnTalepSil.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnTalepSil.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnTalepSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTalepSil.Size = new System.Drawing.Size(177, 36);
            this.btnTalepSil.TabIndex = 3;
            this.btnTalepSil.Text = "Talep Sil";
            this.btnTalepSil.TextColor = System.Drawing.Color.Red;
            this.btnTalepSil.UseVisualStyleBackColor = false;
            this.btnTalepSil.Click += new System.EventHandler(this.btnTalepSil_Click);
            // 
            // TalepOlusturmaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.btnTalepSil);
            this.Controls.Add(this.btnTalepGonder);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxMalzemeTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtBoxTalepAciklamasi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TalepOlusturmaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talep Oluşturma";
            this.Load += new System.EventHandler(this.TalepOlusturmaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxTalepAciklamasi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMalzemeTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private ePOSOne.btnProduct.Button_WOC btnTalepGonder;
        private ePOSOne.btnProduct.Button_WOC btnTalepSil;
    }
}