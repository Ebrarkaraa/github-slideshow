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
    public partial class KayitFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;

        public KayitFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        List<Kullanici> kullanicilar = new List<Kullanici>();

        private void lnkLblKaydimVar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GirisKontrolFrm grsKntrlFrm = new GirisKontrolFrm();
            grsKntrlFrm.Closed += (s, args) => this.Close();
            grsKntrlFrm.Show();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            bool izin = false;
            foreach (Kullanici klnc in kullanicilar)
            {
                if (klnc.kullaniciAdi == txtBoxKullaniciAdi.Text)
                {
                    izin = false;
                    MessageBox.Show("Kullanmaya çalıştığınız kullanıcı adı zaten mevcut!");
                    break;
                }
                else
                {
                    izin = true;
                }
            }
            if (izin)
            {
                kayitOl();
            }
        }

        private void KayitFrm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblKullanici", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Kullanici kullanici = new Kullanici();
                    kullanici.kullaniciId = Convert.ToInt32(read["kullaniciID"]);
                    kullanici.kullaniciAdi = (read["kullaniciAdi"].ToString());
                    kullanici.kullaniciSifre = (read["sifre"].ToString());
                    kullanici.yetki = Convert.ToBoolean(read["yetki"]);
                    kullanici.bolum = (read["bolum"].ToString());
                    kullanici.guncellemeTarihi = (read["guncellemeTarihi"].ToString());
                    kullanicilar.Add(kullanici);

                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void kayitOl()
        {
            DateTime localTime = DateTime.Now;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tblKullanici (kullaniciAdi,sifre,yetki,guncellemeTarihi,bolum) VALUES " +
                    "(@KullaniciAdi,@Sifre,@Yetki,@GuncellemeTarihi,@Bolum)", baglanti);
                komut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = (txtBoxKullaniciAdi.Text);
                komut.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = (txtBoxSifre.Text);
                komut.Parameters.Add("@Yetki", SqlDbType.Bit).Value = (false);
                komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                komut.Parameters.Add("@Bolum", SqlDbType.NVarChar).Value = ("İÇ/DIŞ TİCARET");
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
                txtBoxKullaniciAdi.Text = "";
                txtBoxSifre.Text = "";
                this.Hide();
                GirisKontrolFrm grsKntrlFrm = new GirisKontrolFrm();
                grsKntrlFrm.Closed += (s, args) => this.Close();
                grsKntrlFrm.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        
    }
}
