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
    public partial class HesaplamaFrm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public HesaplamaFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public int urunId;
        public string urunAdi;
        public int siparisID;
        public string siparisAdi;
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        TextBox tb = new TextBox();
        Malzeme mlzm = new Malzeme();
        public List<Parca> parcalar = new List<Parca>();
        public List<Malzeme> malzemeler = new List<Malzeme>();
        string malzemeTuru = "";
        public float fiyat;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select DISTINCT malzemeTuru from tblMalzeme", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbBoxMalzemeTuru.Items.Add(read.GetValue(0).ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }
        private void txtBoxEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxEn;
            onlyFloatValue(sender, e);
        }
        private void txtBoxBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb = txtBoxBoy;
            onlyFloatValue(sender, e);
        }
        private void txtBoxAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO tblParca (urunID,malzemeID,en,boy,parcaAdeti,boya,parcaMaliyeti) VALUES " +
                        "(@urunID,@malzemeID,@en,@boy,@parcaAdeti,@boya,@parcaMaliyeti)", baglanti);
                    komut.Parameters.Add("@urunID", SqlDbType.Int).Value = (this.urunId);
                    komut.Parameters.Add("@malzemeID", SqlDbType.Int).Value = (mlzm.malzemeId);
                    komut.Parameters.Add("@en", SqlDbType.Float).Value = (txtBoxEn.Text);
                    komut.Parameters.Add("@boy", SqlDbType.Float).Value = (txtBoxBoy.Text);
                    komut.Parameters.Add("@parcaAdeti", SqlDbType.Int).Value = (txtBoxAdet.Text);
                    if (chckBoxBoya.Checked)
                    {
                        komut.Parameters.Add("@boya", SqlDbType.NVarChar).Value = (cmbBoxBoya.Text);
                    }
                    else
                    {
                        komut.Parameters.Add("@boya", SqlDbType.NVarChar).Value = ("-");
                    }
                    komut.Parameters.Add("@parcaMaliyeti", SqlDbType.Float).Value = (metreKareCinsindenFiyatHesapla());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Parça başarıyla eklenmiştir.");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                DateTime localTime = DateTime.Now;
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE tblUrun SET toplamMaliyet = toplamMaliyet+(@ekMaliyet*urunAdeti), guncellemeTarihi = @guncellemeTarihi where urunID = @ID", baglanti);
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = (this.urunId);
                    komut.Parameters.Add("@ekMaliyet", SqlDbType.Float).Value = (metreKareCinsindenFiyatHesapla());
                    komut.Parameters.Add("@guncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                this.Hide();
                Forms.ParcaListeleFrm prclstlFrm = new Forms.ParcaListeleFrm();
                prclstlFrm.siparisId = this.siparisID;
                prclstlFrm.siparisAdi = this.siparisAdi;
                prclstlFrm.urunId = this.urunId;
                prclstlFrm.urunAdi = this.urunAdi;
                prclstlFrm.Closed += (s, args) => this.Close();
                prclstlFrm.Show();
            }
        }
        public double metreKareCinsindenFiyatHesapla()
        {
            double parcaAlan = (Convert.ToDouble(txtBoxEn.Text) / 1000) * (Convert.ToDouble(txtBoxBoy.Text) / 1000);
            double parcaFiyat = (parcaAlan * mlzm.birimFiyati);
            parcaFiyat *= Convert.ToInt32(txtBoxAdet.Text);
            return parcaFiyat;
        }

        public void malzemeOzellikleriniGetir()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblMalzeme where malzemeAdi = @malzemeAdi", baglanti);
                komut.Parameters.Add("@malzemeAdi", SqlDbType.NVarChar).Value = (cmbBoxMalzemeAdi.Text);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    mlzm.malzemeId = Convert.ToInt32(read["malzemeID"]);
                    mlzm.malzemeTuru = read["malzemeTuru"].ToString();
                    mlzm.malzemeAdi = read["malzemeAdi"].ToString();
                    mlzm.en = float.Parse(read["en"].ToString());
                    mlzm.boy = float.Parse(read["boy"].ToString());
                    mlzm.yukseklik = float.Parse(read["yukseklik"].ToString());
                    mlzm.gelisFiyati = Convert.ToDouble(read["gelisFiyat"].ToString());
                    mlzm.birimFiyati = Convert.ToDouble(read["birimFiyat"].ToString());
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
            formYenile();
            malzemeTuru = cmbBoxMalzemeTuru.Text.ToUpper();
            cmbBoxMalzemeAdi.Items.Clear();
            if (!string.IsNullOrEmpty(malzemeTuru))
            {
                try
                {
                    baglanti.Open();
                    //sectigimiz malzeme türüne göre malzemeleri çağırıyor, malzemeAdi comboBox ımıza o türdeki malzemeleri ekliyor.
                    SqlCommand komut = new SqlCommand("Select malzemeAdi from tblMalzeme where malzemeTuru = @malzemeTuru", baglanti);
                    komut.Parameters.Add("@malzemeTuru", SqlDbType.NVarChar).Value = (malzemeTuru);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        cmbBoxMalzemeAdi.Items.Add(read["malzemeAdi"].ToString());
                    }
                    baglanti.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void cmbBoxMalzemeAdi_SelectedIndexChanged(object sender, EventArgs e) => malzemeOzellikleriniGetir();



        private void chckBoxLake_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxBoya.Checked)
            {
                cmbBoxBoya.Enabled = true;
            }
            else
            {
                cmbBoxBoya.Enabled = false;
                cmbBoxBoya.Text = "";
            }
        }


        private void formYenile()
        {
            btnParcaEkle.Enabled = false;
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
                item.Visible = true;
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chckbox = (CheckBox)item;
                    chckbox.Checked = false;
                }
                if (item is ComboBox)
                {
                    ComboBox cmbbox = (ComboBox)item;
                    cmbbox.Text = "";
                }
            }
        }

        public bool txtBoxKontrol()
        {
            if (txtBoxEn.Text == "" || txtBoxBoy.Text == "" || txtBoxAdet.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ParcaListeleFrm prclstlFrm = new Forms.ParcaListeleFrm();
            prclstlFrm.siparisId = this.siparisID;
            prclstlFrm.siparisAdi = this.siparisAdi;
            prclstlFrm.urunId = this.urunId;
            prclstlFrm.urunAdi = this.urunAdi;
            prclstlFrm.Closed += (s, args) => this.Close();
            prclstlFrm.Show();
        }

    }

}
