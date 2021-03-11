
namespace ProjeTakipveHesaplama.Forms
{
    partial class MalzemeGuncelleFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMalzemeTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtBoxMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtBoxGelisFiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBirimFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBoy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxYukseklik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxArama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new ePOSOne.btnProduct.Button_WOC();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.btnEkle = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Malzeme Adı:";
            // 
            // txtBoxMalzemeTuru
            // 
            this.txtBoxMalzemeTuru.Location = new System.Drawing.Point(169, 122);
            this.txtBoxMalzemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMalzemeTuru.Name = "txtBoxMalzemeTuru";
            this.txtBoxMalzemeTuru.Size = new System.Drawing.Size(163, 22);
            this.txtBoxMalzemeTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Malzeme Türü:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 251);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1207, 324);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtBoxMalzemeAdi
            // 
            this.txtBoxMalzemeAdi.Location = new System.Drawing.Point(169, 155);
            this.txtBoxMalzemeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMalzemeAdi.Name = "txtBoxMalzemeAdi";
            this.txtBoxMalzemeAdi.Size = new System.Drawing.Size(163, 22);
            this.txtBoxMalzemeAdi.TabIndex = 2;
            // 
            // txtBoxGelisFiyati
            // 
            this.txtBoxGelisFiyati.Location = new System.Drawing.Point(542, 154);
            this.txtBoxGelisFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGelisFiyati.Name = "txtBoxGelisFiyati";
            this.txtBoxGelisFiyati.Size = new System.Drawing.Size(163, 22);
            this.txtBoxGelisFiyati.TabIndex = 4;
            this.txtBoxGelisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxGelisFiyati_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Geliş Fiyatı:";
            // 
            // txtBoxBirimFiyati
            // 
            this.txtBoxBirimFiyati.Location = new System.Drawing.Point(542, 121);
            this.txtBoxBirimFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBirimFiyati.Name = "txtBoxBirimFiyati";
            this.txtBoxBirimFiyati.Size = new System.Drawing.Size(163, 22);
            this.txtBoxBirimFiyati.TabIndex = 3;
            this.txtBoxBirimFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBirimFiyati_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // txtBoxBoy
            // 
            this.txtBoxBoy.Location = new System.Drawing.Point(888, 154);
            this.txtBoxBoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBoy.Name = "txtBoxBoy";
            this.txtBoxBoy.Size = new System.Drawing.Size(163, 22);
            this.txtBoxBoy.TabIndex = 6;
            this.txtBoxBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBoy_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Boy:";
            // 
            // txtBoxEn
            // 
            this.txtBoxEn.Location = new System.Drawing.Point(888, 121);
            this.txtBoxEn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEn.Name = "txtBoxEn";
            this.txtBoxEn.Size = new System.Drawing.Size(163, 22);
            this.txtBoxEn.TabIndex = 5;
            this.txtBoxEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEn_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(755, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "En:";
            // 
            // txtBoxYukseklik
            // 
            this.txtBoxYukseklik.Location = new System.Drawing.Point(888, 189);
            this.txtBoxYukseklik.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxYukseklik.Name = "txtBoxYukseklik";
            this.txtBoxYukseklik.Size = new System.Drawing.Size(163, 22);
            this.txtBoxYukseklik.TabIndex = 7;
            this.txtBoxYukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxYukseklik_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Yükseklik:";
            // 
            // txtBoxArama
            // 
            this.txtBoxArama.Location = new System.Drawing.Point(659, 224);
            this.txtBoxArama.Name = "txtBoxArama";
            this.txtBoxArama.Size = new System.Drawing.Size(218, 22);
            this.txtBoxArama.TabIndex = 11;
            this.txtBoxArama.TextChanged += new System.EventHandler(this.txtBoxArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(590, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "ARA:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.malzemelerToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 31);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            this.anaMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaMenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            this.anaMenuToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.anaMenuToolStripMenuItem.Text = "Ana Menü";
            this.anaMenuToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 27);
            this.toolStripMenuItem1.Text = "Talepler";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.taleplerToolStripMenuItem_Click);
            // 
            // malzemelerToolStripMenuItem
            // 
            this.malzemelerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.malzemelerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.malzemelerToolStripMenuItem.Name = "malzemelerToolStripMenuItem";
            this.malzemelerToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.malzemelerToolStripMenuItem.Text = "Malzemeler";
            this.malzemelerToolStripMenuItem.Click += new System.EventHandler(this.malzemeGüncelleToolStripMenuItem_Click_1);
            // 
            // kullanıcılarToolStripMenuItem1
            // 
            this.kullanıcılarToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.kullanıcılarToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullanıcılarToolStripMenuItem1.Name = "kullanıcılarToolStripMenuItem1";
            this.kullanıcılarToolStripMenuItem1.Size = new System.Drawing.Size(106, 27);
            this.kullanıcılarToolStripMenuItem1.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem1.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BorderColor = System.Drawing.Color.Red;
            this.btnSil.ButtonColor = System.Drawing.Color.White;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(383, 208);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(177, 36);
            this.btnSil.TabIndex = 49;
            this.btnSil.Text = "Sil";
            this.btnSil.TextColor = System.Drawing.Color.Red;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.ButtonColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(200, 208);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(177, 36);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.ButtonColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(17, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.Size = new System.Drawing.Size(177, 36);
            this.btnEkle.TabIndex = 47;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_WOC1.Location = new System.Drawing.Point(17, 208);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(177, 36);
            this.button_WOC1.TabIndex = 8;
            this.button_WOC1.Text = "Ekle";
            this.button_WOC1.TextColor = System.Drawing.Color.ForestGreen;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_WOC2.ButtonColor = System.Drawing.Color.White;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_WOC2.Location = new System.Drawing.Point(200, 208);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(177, 36);
            this.button_WOC2.TabIndex = 9;
            this.button_WOC2.Text = "Güncelle";
            this.button_WOC2.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.BorderColor = System.Drawing.Color.Red;
            this.button_WOC3.ButtonColor = System.Drawing.Color.White;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.Color.Red;
            this.button_WOC3.Location = new System.Drawing.Point(383, 208);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(177, 36);
            this.button_WOC3.TabIndex = 10;
            this.button_WOC3.Text = "Sil";
            this.button_WOC3.TextColor = System.Drawing.Color.Red;
            this.button_WOC3.UseVisualStyleBackColor = false;
            this.button_WOC3.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MalzemeGuncelleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtBoxArama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxYukseklik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxBoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxBirimFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxGelisFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMalzemeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMalzemeTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1240, 590);
            this.Name = "MalzemeGuncelleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzemeler";
            this.Load += new System.EventHandler(this.MalzemeGuncelleFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMalzemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtBoxMalzemeAdi;
        private System.Windows.Forms.TextBox txtBoxGelisFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxBirimFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxYukseklik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxArama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem malzemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem1;
        private ePOSOne.btnProduct.Button_WOC btnSil;
        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private ePOSOne.btnProduct.Button_WOC btnEkle;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
    }
}