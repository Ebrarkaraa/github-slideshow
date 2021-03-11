using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakipveHesaplama
{
    public partial class YetkiliFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        bool selected = false;
        public YetkiliFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        private void YetkiliFrm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Talep ID", 60,
                "Oluşturan Kullanıcı", 140,
                "Malzeme Türü", 100,
                "Talep Açıklaması", 220,
                "Oluşturma Tarihi", 140);
            listView1Listele();
        }
        public void listView1SutunEkle(string a, int a1,
            string b, int b1,
            string c, int c1,
            string d, int d1,
            string e, int e1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
            listView1.Columns.Add(e, e1);
        }
        public void listView1Listele()
        {
            listView1.Items.Clear();

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from talepler", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["talepID"].ToString();
                    ekle.SubItems.Add(read["kullaniciAdi"].ToString());
                    ekle.SubItems.Add(read["malzemeTuru"].ToString());
                    ekle.SubItems.Add(read["talepAciklamasi"].ToString());
                    ekle.SubItems.Add(read["olusturmaTarihi"].ToString());
                    listView1.Items.Add(ekle);
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenuFrm = new AnaMenu();
            anaMenuFrm.Closed += (s, args) => this.Close();
            anaMenuFrm.Show();
        }
        private void yetkiliEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkiliFrm ytklFrm = new YetkiliFrm();
            ytklFrm.Closed += (s, args) => this.Close();
            ytklFrm.Show();
        }
        private void malzemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MalzemeGuncelleFrm mlzmGncllmFrm = new Forms.MalzemeGuncelleFrm();
            mlzmGncllmFrm.Closed += (s, args) => this.Close();
            mlzmGncllmFrm.Show();
        }

        private void kullanıcılarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.KullaniciListeleFrm kllncLstlFrm = new Forms.KullaniciListeleFrm();
            kllncLstlFrm.Closed += (s, args) => this.Close();
            kllncLstlFrm.Show();
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM tblTalep WHERE talepID = @TalepID", baglanti);
                    komut.Parameters.Add("@TalepID", SqlDbType.Int).Value = (Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Talep Silinmiştir.");
                    listView1Listele();
                    selected = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir talep seçiniz!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                selected = false;
                return;
            }
            else
            {
                selected = true;
                lblTalepAciklamasi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            
        }

    }
}
