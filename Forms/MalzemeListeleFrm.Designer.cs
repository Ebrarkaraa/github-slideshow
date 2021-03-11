
namespace ProjeTakipveHesaplama
{
    partial class Malzemefrm
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
            this.cmbBoxMalzemeTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxArama = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliEkraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxMalzemeTuru
            // 
            this.cmbBoxMalzemeTuru.FormattingEnabled = true;
            this.cmbBoxMalzemeTuru.Location = new System.Drawing.Point(163, 135);
            this.cmbBoxMalzemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxMalzemeTuru.Name = "cmbBoxMalzemeTuru";
            this.cmbBoxMalzemeTuru.Size = new System.Drawing.Size(164, 24);
            this.cmbBoxMalzemeTuru.TabIndex = 0;
            this.cmbBoxMalzemeTuru.Text = "HEPSİ";
            this.cmbBoxMalzemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMalzemeTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzeme Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "ARA:";
            // 
            // txtBoxArama
            // 
            this.txtBoxArama.Location = new System.Drawing.Point(425, 132);
            this.txtBoxArama.Name = "txtBoxArama";
            this.txtBoxArama.Size = new System.Drawing.Size(218, 22);
            this.txtBoxArama.TabIndex = 12;
            this.txtBoxArama.TextChanged += new System.EventHandler(this.txtBoxArama_TextChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(2115, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            this.anaMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaMenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            this.anaMenuToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.anaMenuToolStripMenuItem.Text = "Ana Menü";
            this.anaMenuToolStripMenuItem.Click += new System.EventHandler(this.anaMenuToolStripMenuItem_Click);
            // 
            // malzemelerToolStripMenuItem
            // 
            this.malzemelerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malzemelerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.malzemelerToolStripMenuItem.Name = "malzemelerToolStripMenuItem";
            this.malzemelerToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.malzemelerToolStripMenuItem.Text = "Malzemeler";
            this.malzemelerToolStripMenuItem.Click += new System.EventHandler(this.malzemelerToolStripMenuItem_Click_1);
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
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1216, 415);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Malzemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxMalzemeTuru);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Malzemefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzemeler";
            this.Load += new System.EventHandler(this.Malzemefrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxMalzemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliEkraniToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}