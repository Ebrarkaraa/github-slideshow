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
    public partial class Malzemefrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public Malzemefrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Malzemefrm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.girisYetkisi)//girdiği yetkiye göre yetkili kısmı açılıp kapanıcak
            {
                menuStrip1.Items[2].Visible = true;
            }
            else
            {
                menuStrip1.Items[2].Visible = false;
            }
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Malzeme ID", 80,
                "Malzeme Türü", 90,
                "Malzeme Adı", 130,
                "En", 50,
                "Boy", 50,
                "Yükseklik", 70,
                "Geliş Fiyatı", 70,
                "Birim Fiyatı", 70,
                "Güncellenme Tarihi", 130);
            listView1Listele();
        }
        public void tutuneGoreVeriGetir(string mlzmTuru)
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblMalzeme where malzemeTuru = @MalzemeTuru", baglanti);
                komut.Parameters.Add("@MalzemeTuru", SqlDbType.NVarChar).Value = (mlzmTuru);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["malzemeID"].ToString();
                    ekle.SubItems.Add(read["malzemeTuru"].ToString());
                    ekle.SubItems.Add(read["malzemeAdi"].ToString());
                    ekle.SubItems.Add(read["en"].ToString());
                    ekle.SubItems.Add(read["boy"].ToString());
                    ekle.SubItems.Add(read["yukseklik"].ToString());
                    ekle.SubItems.Add(read["gelisFiyat"].ToString());
                    ekle.SubItems.Add(read["birimFiyat"].ToString());
                    ekle.SubItems.Add(read["guncellenmeTarihi"].ToString());
                    listView1.Items.Add(ekle);
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ismeGoreVeriGetir(string mlzmAdi)
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ismeGoreMalzeme", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("malzemeAdi", mlzmAdi);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["malzemeID"].ToString();
                    ekle.SubItems.Add(read["malzemeTuru"].ToString());
                    ekle.SubItems.Add(read["malzemeAdi"].ToString());
                    ekle.SubItems.Add(read["en"].ToString());
                    ekle.SubItems.Add(read["boy"].ToString());
                    ekle.SubItems.Add(read["yukseklik"].ToString());
                    ekle.SubItems.Add(read["gelisFiyat"].ToString());
                    ekle.SubItems.Add(read["birimFiyat"].ToString());
                    ekle.SubItems.Add(read["guncellenmeTarihi"].ToString());
                    listView1.Items.Add(ekle);
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void listView1SutunEkle(string a, int a1,
           string b, int b1,
           string c, int c1,
           string d, int d1,
           string e, int e1,
           string f, int f1,
           string g, int g1,
           string h, int h1,
           string i, int i1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
            listView1.Columns.Add(e, e1);
            listView1.Columns.Add(f, f1);
            listView1.Columns.Add(g, g1);
            listView1.Columns.Add(h, h1);
            listView1.Columns.Add(i, i1);
        }
        public void listView1Listele()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblMalzeme ORDER BY malzemeTuru", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["malzemeID"].ToString();
                    ekle.SubItems.Add(read["malzemeTuru"].ToString());
                    ekle.SubItems.Add(read["malzemeAdi"].ToString());
                    ekle.SubItems.Add(read["en"].ToString());
                    ekle.SubItems.Add(read["boy"].ToString());
                    ekle.SubItems.Add(read["yukseklik"].ToString());
                    ekle.SubItems.Add(read["gelisFiyat"].ToString());
                    ekle.SubItems.Add(read["birimFiyat"].ToString());
                    ekle.SubItems.Add(read["guncellenmeTarihi"].ToString());
                    listView1.Items.Add(ekle);
                }
                read.Close();
                SqlCommand komut2 = new SqlCommand("Select DISTINCT malzemeTuru from tblMalzeme", baglanti);
                read = komut2.ExecuteReader();
                cmbBoxMalzemeTuru.Items.Add("HEPSİ");
                while (read.Read())
                {
                    cmbBoxMalzemeTuru.Items.Add(read["malzemeTuru"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cmbBoxMalzemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxMalzemeTuru.Text == "HEPSİ")
            {
                cmbBoxMalzemeTuru.Items.Clear();
                listView1Listele();
            }
            else
            {
                tutuneGoreVeriGetir(cmbBoxMalzemeTuru.Text);
            }
        }

        private void txtBoxArama_TextChanged(object sender, EventArgs e)
        {
            ismeGoreVeriGetir(txtBoxArama.Text);
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu menu = new AnaMenu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void malzemelerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Malzemefrm mlzmFrm = new Malzemefrm();
            mlzmFrm.Closed += (s, args) => this.Close();
            mlzmFrm.Show();
        }

        private void yetkiliEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkiliFrm ytklFrm = new YetkiliFrm();
            ytklFrm.Closed += (s, args) => this.Close();
            ytklFrm.Show();
        }
        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.TalepOlusturmaFrm tlpFrm = new Forms.TalepOlusturmaFrm();
            tlpFrm.Closed += (s, args) => this.Close();
            tlpFrm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
