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
    public partial class KullaniciListeleFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public KullaniciListeleFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        List<Kullanici> kullanicilar = new List<Kullanici>();
        bool selected = false;
        string eskiKullaniciAdi;
        private void KullaniciListeleFrm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Kullanıcı ID", 70,
                "Kullanıcı Adı", 120,
                "Kullanıcı Şifre", 100,
                "Yetki", 120,
                "Bölüm", 120,
                "Güncelleme Tarihi", 120);
            listView1Listele();
        }
        public void listView1SutunEkle(string a, int a1,
            string b, int b1,
            string c, int c1,
            string d, int d1,
            string e, int e1,
            string f, int f1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
            listView1.Columns.Add(e, e1);
            listView1.Columns.Add(f, f1);
        }
        public void listView1Listele()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblKullanici", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Kullanici kullanici = new Kullanici();
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["kullaniciID"].ToString();
                    ekle.SubItems.Add(read["kullaniciAdi"].ToString());
                    ekle.SubItems.Add(read["sifre"].ToString());
                    ekle.SubItems.Add(read["yetki"].ToString());
                    ekle.SubItems.Add(read["bolum"].ToString());
                    ekle.SubItems.Add(read["guncellemeTarihi"].ToString());
                    kullanici.kullaniciId = Convert.ToInt32(read["kullaniciID"]);
                    kullanici.kullaniciAdi = (read["kullaniciAdi"].ToString());
                    kullanici.kullaniciSifre = (read["sifre"].ToString());
                    kullanici.yetki = Convert.ToBoolean(read["yetki"]);
                    kullanici.bolum = (read["bolum"].ToString());
                    kullanici.guncellemeTarihi = (read["guncellemeTarihi"].ToString());
                    kullanicilar.Add(kullanici);
                    listView1.Items.Add(ekle);

                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.KullaniciListeleFrm kllncLstlFrm = new Forms.KullaniciListeleFrm();
            kllncLstlFrm.Closed += (s, args) => this.Close();
            kllncLstlFrm.Show();
        }


        private void malzemeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MalzemeGuncelleFrm mlzmGncllmFrm = new Forms.MalzemeGuncelleFrm();
            mlzmGncllmFrm.Closed += (s, args) => this.Close();
            mlzmGncllmFrm.Show();
        }

        private void taleplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkiliFrm ytklFrm = new YetkiliFrm();
            ytklFrm.Closed += (s, args) => this.Close();
            ytklFrm.Show();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenuFrm = new AnaMenu();
            anaMenuFrm.Closed += (s, args) => this.Close();
            anaMenuFrm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                selected = false;
                txtBoxKullaniciAdi.Text = "";
                eskiKullaniciAdi = "";
                txtBoxSifre.Text = "";
                cmbBoxYetki.Text = "";
                cmbBoxBolum.Text = "";
                return;
            }
            else
            {
                selected = true;
                txtBoxKullaniciAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
                eskiKullaniciAdi = txtBoxKullaniciAdi.Text;
                txtBoxSifre.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cmbBoxYetki.Text = listView1.SelectedItems[0].SubItems[3].Text;
                cmbBoxBolum.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                bool izin = true;
                foreach (Kullanici klnc in kullanicilar)
                {
                    if (klnc.kullaniciAdi != eskiKullaniciAdi && klnc.kullaniciAdi == txtBoxKullaniciAdi.Text)
                    {
                        izin = false;
                    }
                }
                if (selected && izin == true)
                {
                    DateTime localTime = DateTime.Now;
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("UPDATE tblKullanici SET kullaniciAdi = @KullaniciAdi, sifre = @Sifre, yetki = @Yetki, bolum = @Bolum, guncellemeTarihi = @GuncellemeTarihi where kullaniciID = @ID", baglanti);
                        komut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = (txtBoxKullaniciAdi.Text);
                        komut.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = (txtBoxSifre.Text);
                        komut.Parameters.Add("@Yetki", SqlDbType.Bit).Value = (cmbBoxYetki.Text);
                        komut.Parameters.Add("@Bolum", SqlDbType.NVarChar).Value = (cmbBoxBolum.Text);
                        komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                        komut.Parameters.Add("@ID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı Başarıyla Güncellenmiştir.");
                        kullanicilar.Clear();
                        listView1Listele();
                        selected = false;
                        txtBoxKullaniciAdi.Text = "";
                        txtBoxSifre.Text = "";
                        cmbBoxYetki.Text = "";
                        cmbBoxBolum.Text = "";
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı seçmeden işlem yapamazsınız veya aynı kullanıcı adlı birisini ekleyemezsiniz!");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                bool izin = true;
                foreach (Kullanici klnc in kullanicilar)
                {
                    if (klnc.kullaniciAdi == txtBoxKullaniciAdi.Text)
                    {
                        izin = false;
                    }
                }
                if (izin == true)
                {
                    DateTime localTime = DateTime.Now;
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("INSERT INTO tblKullanici (kullaniciAdi,sifre,yetki,bolum,guncellemeTarihi) VALUES " +
                            "(@KullaniciAdi,@Sifre,@Yetki,@Bolum,@GuncellemeTarihi)", baglanti);
                        komut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = (txtBoxKullaniciAdi.Text);
                        komut.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = (txtBoxSifre.Text);
                        komut.Parameters.Add("@Yetki", SqlDbType.Bit).Value = (cmbBoxYetki.Text);
                        komut.Parameters.Add("@Bolum", SqlDbType.NVarChar).Value = (cmbBoxBolum.Text);
                        komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı Başarıyla Eklenmiştir.");
                        kullanicilar.Clear();
                        listView1Listele();
                        selected = false;
                        txtBoxKullaniciAdi.Text = "";
                        txtBoxSifre.Text = "";
                        cmbBoxYetki.Text = "";
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Aynı kullanıcı adlı birisini ekleyemezsiniz!");
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM tblKullanici WHERE kullaniciID = @KullaniciID", baglanti);
                    komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Silinmiştir.");
                    kullanicilar.Clear();
                    listView1Listele();
                    selected = false;
                    txtBoxKullaniciAdi.Text = "";
                    txtBoxSifre.Text = "";
                    cmbBoxYetki.Text = "";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz!");
            }
        }
        public bool txtBoxKontrol()
        {
            if (txtBoxKullaniciAdi.Text == "" || txtBoxSifre.Text == "" || cmbBoxYetki.Text == "" || cmbBoxBolum.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

