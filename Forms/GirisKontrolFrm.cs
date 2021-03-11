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
using MaterialSkin;

namespace ProjeTakipveHesaplama.Forms
{
    public partial class GirisKontrolFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public GirisKontrolFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void GirisKontrolFrm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.beniHatirla == true)
            {
                txtBoxKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                txtBoxSifre.Text = Properties.Settings.Default.sifre;
                chckBoxBeniHatirla.Checked = Properties.Settings.Default.beniHatirla;
            }
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (girisKontrol(txtBoxKullaniciAdi.Text, txtBoxSifre.Text))//kullanıcı adı şifre databasedeki kullanıcı bilgileriyle kontrol edilip giriş sağlanıcak
            {
                this.Hide();
                AnaMenu anaMenuFrm = new AnaMenu();
                anaMenuFrm.Closed += (s, args) => this.Close();
                anaMenuFrm.Show();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut değil!");
            }
        }
        private void lnkLblKayitOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            KayitFrm kytFrm = new KayitFrm();
            kytFrm.Closed += (s, args) => this.Close();
            kytFrm.Show();
        }

        public bool girisKontrol(string kullaniciAdi, string sifre)
        {
            bool izin = false;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblKullanici where kullaniciAdi = @KullaniciAdi and sifre = @Sifre", baglanti);
                komut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = (kullaniciAdi);
                komut.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = (sifre);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Properties.Settings.Default.kullaniciID = Convert.ToInt32(read["kullaniciID"]);
                    Properties.Settings.Default.kullaniciAdi = read["kullaniciAdi"].ToString();
                    Properties.Settings.Default.sifre = read["sifre"].ToString();
                    Properties.Settings.Default.kullaniciBolum = read["bolum"].ToString();
                    Properties.Settings.Default.girisYetkisi = Convert.ToBoolean(read["yetki"]);
                    if (chckBoxBeniHatirla.Checked)
                    {
                        Properties.Settings.Default.beniHatirla = true;
                    }
                    else
                    {
                        Properties.Settings.Default.beniHatirla = false;
                    }
                    Properties.Settings.Default.Save();

                    izin = true;
                }
                read.Close();
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return izin;
        }

    }
}
