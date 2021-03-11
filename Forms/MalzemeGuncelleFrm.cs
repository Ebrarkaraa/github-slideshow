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
    public partial class MalzemeGuncelleFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public MalzemeGuncelleFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public List<Malzeme> malzemeler = new List<Malzeme>();
        bool selected = false;
        private string eskiMalzemeAdi;
        TextBox tb = new TextBox();
        private void MalzemeGuncelleFrm_Load(object sender, EventArgs e)
        {
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
                "Güncellenme Tarihi", 130,
                "Guncelleyen Kişi", 130);

            selected = true;

            listView1Listele();
        }
        public void listView1SutunEkle(string a, int a1,
           string b, int b1,
           string c, int c1,
           string d, int d1,
           string e, int e1,
           string f, int f1,
           string g, int g1,
           string h, int h1,
           string i, int i1,
           string j, int j1)
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
            listView1.Columns.Add(j, j1);
        }
        public void listView1Listele()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT M.*, K.kullaniciAdi FROM tblMalzeme M LEFT JOIN tblKullanici K ON M.kullaniciID = K.kullaniciID", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Malzeme mlzm = new Malzeme();
                    mlzm.malzemeId = Convert.ToInt32(read["malzemeID"]);
                    mlzm.kullaniciAdi = read["kullaniciAdi"].ToString();
                    mlzm.malzemeTuru = read["malzemeTuru"].ToString();
                    mlzm.malzemeAdi = read["malzemeAdi"].ToString();
                    mlzm.en = float.Parse(read["en"].ToString());
                    mlzm.boy = float.Parse(read["boy"].ToString());
                    mlzm.yukseklik = float.Parse(read["yukseklik"].ToString());
                    mlzm.gelisFiyati = Convert.ToDouble(read["gelisFiyat"].ToString());
                    mlzm.birimFiyati = Convert.ToDouble(read["birimFiyat"].ToString());
                    mlzm.guncellenmeTarihi = read["guncellenmeTarihi"].ToString();
                    malzemeler.Add(mlzm);
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
            foreach (Malzeme mlzm in malzemeler)
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = mlzm.malzemeId.ToString();
                ekle.SubItems.Add(mlzm.malzemeTuru.ToString());
                ekle.SubItems.Add(mlzm.malzemeAdi.ToString());
                ekle.SubItems.Add(mlzm.en.ToString());
                ekle.SubItems.Add(mlzm.boy.ToString());
                ekle.SubItems.Add(mlzm.yukseklik.ToString());
                ekle.SubItems.Add(mlzm.gelisFiyati.ToString());
                ekle.SubItems.Add(mlzm.birimFiyati.ToString());
                ekle.SubItems.Add(mlzm.guncellenmeTarihi.ToString());
                if (mlzm.kullaniciAdi != null)
                {
                    ekle.SubItems.Add(mlzm.kullaniciAdi.ToString());
                }
                else
                {
                    ekle.SubItems.Add("-");
                }
                listView1.Items.Add(ekle);
            }

        }


        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenuFrm = new AnaMenu();
            anaMenuFrm.Closed += (s, args) => this.Close();
            anaMenuFrm.Show();
        }
        private void malzemeGüncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.KullaniciListeleFrm kllncLstlFrm = new Forms.KullaniciListeleFrm();
            kllncLstlFrm.Closed += (s, args) => this.Close();
            kllncLstlFrm.Show();
        }

        private void txtBoxArama_TextChanged(object sender, EventArgs e)
        {
            ismeGoreVeriGetir(txtBoxArama.Text);
        }
        public void ismeGoreVeriGetir(string mlzmAdi)
        {
            listView1.Items.Clear();
            malzemeler.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("ismeGoreMalzeme", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("malzemeAdi", mlzmAdi);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Malzeme mlzm = new Malzeme();
                    mlzm.malzemeId = Convert.ToInt32(read["malzemeID"]);
                    mlzm.malzemeTuru = read["malzemeTuru"].ToString();
                    mlzm.malzemeAdi = read["malzemeAdi"].ToString();
                    mlzm.en = float.Parse(read["en"].ToString());
                    mlzm.boy = float.Parse(read["boy"].ToString());
                    mlzm.yukseklik = float.Parse(read["yukseklik"].ToString());
                    mlzm.gelisFiyati = Convert.ToDouble(read["gelisFiyat"].ToString());
                    mlzm.birimFiyati = Convert.ToDouble(read["birimFiyat"].ToString());
                    mlzm.guncellenmeTarihi = read["guncellenmeTarihi"].ToString();
                    malzemeler.Add(mlzm);
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
            foreach (Malzeme mlzm in malzemeler)
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = mlzm.malzemeId.ToString();
                ekle.SubItems.Add(mlzm.malzemeTuru.ToString());
                ekle.SubItems.Add(mlzm.malzemeAdi.ToString());
                ekle.SubItems.Add(mlzm.en.ToString());
                ekle.SubItems.Add(mlzm.boy.ToString());
                ekle.SubItems.Add(mlzm.yukseklik.ToString());
                ekle.SubItems.Add(mlzm.gelisFiyati.ToString());
                ekle.SubItems.Add(mlzm.birimFiyati.ToString());
                ekle.SubItems.Add(mlzm.guncellenmeTarihi.ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                bool izin = true;
                foreach (Malzeme mlzm in malzemeler)
                {
                    if (mlzm.malzemeAdi != eskiMalzemeAdi && mlzm.malzemeAdi == txtBoxMalzemeAdi.Text)
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
                        SqlCommand komut = new SqlCommand("UPDATE tblMalzeme SET " +
                            "kullaniciID = @KullaniciID, " +
                            "malzemeTuru = @MalzemeTuru, " +
                            "malzemeAdi = @MalzemeAdi, " +
                            "en = @En, " +
                            "boy = @Boy, " +
                            "yukseklik = @Yukseklik, " +
                            "gelisFiyat = @GelisFiyati, " +
                            "birimFiyat = @BirimFiyati, " +
                            "guncellenmeTarihi = @GuncellenmeTarihi " +
                            "where malzemeID = @ID", baglanti);
                        komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);
                        komut.Parameters.Add("@MalzemeTuru", SqlDbType.NVarChar).Value = (txtBoxMalzemeTuru.Text);
                        komut.Parameters.Add("@MalzemeAdi", SqlDbType.NVarChar).Value = (txtBoxMalzemeAdi.Text);
                        komut.Parameters.Add("@En", SqlDbType.Float).Value = (txtBoxEn.Text);
                        komut.Parameters.Add("@Boy", SqlDbType.Float).Value = (txtBoxBoy.Text);
                        komut.Parameters.Add("@Yukseklik", SqlDbType.Float).Value = (txtBoxYukseklik.Text);
                        komut.Parameters.Add("@GelisFiyati", SqlDbType.Float).Value = (txtBoxGelisFiyati.Text);
                        komut.Parameters.Add("@BirimFiyati", SqlDbType.Float).Value = (txtBoxBirimFiyati.Text);
                        komut.Parameters.Add("@GuncellenmeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                        komut.Parameters.Add("@ID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Malzeme Başarıyla Güncellenmiştir.");
                        malzemeler.Clear();
                        listView1Listele();
                        selected = false;
                        txtBoxTemizle();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Malzeme seçmeden işlem yapamazsınız veya aynı malzeme adını kullanamazsınız!");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                bool izin = true;
                foreach (Malzeme mlzm in malzemeler)
                {
                    if (mlzm.malzemeAdi == txtBoxMalzemeAdi.Text)
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
                        SqlCommand komut = new SqlCommand("INSERT INTO tblMalzeme (kullaniciID,malzemeTuru,malzemeAdi,en,boy,yukseklik,gelisFiyat,birimFiyat,guncellenmeTarihi) VALUES " +
                            "(@KullaniciID,@MalzemeTuru,@MalzemeAdi,@En,@Boy,@Yukseklik,@GelisFiyati,@BirimFiyati,@GuncellenmeTarihi)", baglanti);
                        komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);
                        komut.Parameters.Add("@MalzemeTuru", SqlDbType.NVarChar).Value = (txtBoxMalzemeTuru.Text.ToUpper());
                        komut.Parameters.Add("@MalzemeAdi", SqlDbType.NVarChar).Value = (txtBoxMalzemeAdi.Text);
                        komut.Parameters.Add("@En", SqlDbType.Float).Value = (txtBoxEn.Text);
                        komut.Parameters.Add("@Boy", SqlDbType.Float).Value = (txtBoxBoy.Text);
                        komut.Parameters.Add("@Yukseklik", SqlDbType.Float).Value = (txtBoxYukseklik.Text);
                        komut.Parameters.Add("@GelisFiyati", SqlDbType.Float).Value = (txtBoxGelisFiyati.Text);
                        komut.Parameters.Add("@BirimFiyati", SqlDbType.Float).Value = (txtBoxBirimFiyati.Text);
                        komut.Parameters.Add("@GuncellenmeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Malzeme Başarıyla Eklenmiştir.");
                        malzemeler.Clear();
                        listView1Listele();
                        selected = false;
                        txtBoxTemizle();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Aynı malzeme adını birden fazla malzemede kullanamazsınız!");
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
                    SqlCommand komut = new SqlCommand("DELETE FROM tblMalzeme WHERE malzemeID = @MalzemeID", baglanti);
                    komut.Parameters.Add("@MalzemeID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Malzeme Silinmiştir.");
                    malzemeler.Clear();
                    listView1Listele();
                    selected = false;
                    txtBoxTemizle();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir Malzeme seçiniz!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                selected = false;
                txtBoxMalzemeAdi.Text = "";
                txtBoxMalzemeTuru.Text = "";
                txtBoxBirimFiyati.Text = "";
                txtBoxGelisFiyati.Text = "";
                txtBoxEn.Text = "";
                txtBoxBoy.Text = "";
                txtBoxYukseklik.Text = "";
                eskiMalzemeAdi = "";
                return;
            }
            else
            {
                txtBoxMalzemeTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtBoxMalzemeAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                eskiMalzemeAdi = txtBoxMalzemeAdi.Text;
                txtBoxEn.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtBoxBoy.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtBoxYukseklik.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtBoxGelisFiyati.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txtBoxBirimFiyati.Text = listView1.SelectedItems[0].SubItems[7].Text;
                selected = true;
            }
        }
        public void txtBoxTemizle()
        {
            txtBoxMalzemeAdi.Text = "";
            txtBoxMalzemeTuru.Text = "";
            txtBoxBirimFiyati.Text = "";
            txtBoxGelisFiyati.Text = "";
            txtBoxEn.Text = "";
            txtBoxBoy.Text = "";
            txtBoxYukseklik.Text = "";
            eskiMalzemeAdi = "";
        }

        private void txtBoxBirimFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }

        private void txtBoxGelisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }

        private void txtBoxEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }

        private void txtBoxBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }

        private void txtBoxYukseklik_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }
        public void onlyFloatValue(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 && tb.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }


        public bool txtBoxKontrol()
        {
            if (txtBoxMalzemeTuru.Text == "" || txtBoxMalzemeAdi.Text == "" || txtBoxBirimFiyati.Text == "" || txtBoxGelisFiyati.Text == "" ||
                txtBoxEn.Text == "" || txtBoxBoy.Text == "" || txtBoxYukseklik.Text == "")
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
