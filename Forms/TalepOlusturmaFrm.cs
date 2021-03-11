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

namespace ProjeTakipveHesaplama.Forms
{
    public partial class TalepOlusturmaFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        bool selected = false;
        public TalepOlusturmaFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        //kullanıcı fiyatını istediği malzemeyi veya fiyatsız malzemeyi seçip açıklama yazıcak,
        //bu talep databasede tutulup yetkili ekranında talepler bölümünde listelenicek
        private void TalepOlusturmaFrm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Talep ID", 100,
                "Malzeme Türü", 100,
                "Talep Açıklaması", 340,
                "Oluşturma Tarihi", 120);
            listView1Listele();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT DISTINCT malzemeTuru FROM tblMalzeme order by malzemeTuru asc", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbBoxMalzemeTuru.Items.Add(read.GetValue(0));
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            
        }


        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            if (txtBoxTalepAciklamasi.Text != "")
            {
                DateTime localTime = DateTime.Now;
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO tblTalep (kullaniciID,malzemeTuru,talepAciklamasi,olusturmaTarihi) VALUES " +
                        "(@KullaniciID,@MalzemeTuru,@TalepAciklamasi,@OlusturmaTarihi)", baglanti);
                    komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);
                    komut.Parameters.Add("@MalzemeTuru", SqlDbType.NVarChar).Value = (cmbBoxMalzemeTuru.Text);
                    komut.Parameters.Add("@TalepAciklamasi", SqlDbType.NVarChar).Value = (txtBoxTalepAciklamasi.Text);
                    komut.Parameters.Add("@OlusturmaTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Talebiniz Başarıyla Gönderilmiştir.");
                    listView1Listele();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen talep açıklamasını boş bırakmayınız!");
            }
        }


        public void listView1SutunEkle(string a, int a1,
            string b, int b1,
            string c, int c1,
            string d, int d1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
        }
        public void listView1Listele()
        {
            listView1.Items.Clear();

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblTalep where kullaniciID = @KullaniciID", baglanti);
                komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);//giriş yapan kullanıcının idsine göre talepleri listelenicek
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["talepID"].ToString();
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

        private void btnTalepSil_Click(object sender, EventArgs e)
        {
            
            if (selected)
            {

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM tblTalep WHERE talepID = @TalepID", baglanti);
                    komut.Parameters.Add("@TalepID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Talebiniz Silinmiştir.");
                    listView1Listele();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir adet talep seçiniz.");
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
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu = new AnaMenu();
            anamenu.Closed += (s, args) => this.Close();
            anamenu.Show();
        }

    }
}
