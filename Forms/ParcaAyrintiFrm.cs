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
    public partial class ParcaAyrintiFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public ParcaAyrintiFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public int urunId;
        public string urunAdi;
        public string siparisAdi;
        public int siparisId;
        Parca prc = new Parca();
        public int parcaId;
        public double malzemeBirimFiyat;
        public int malzemeId;
        public double eskiParcaFiyat;

        private void ParcaAyrintiFrm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select DISTINCT malzemeTuru from tblMalzeme", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbBoxMalzemeTuru.Items.Add(read.GetValue(0).ToString().ToUpper());
                }
                read.Close();
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT P.*,dbo.Fn_ToplamParcaMaliyeti(P.parcaMaliyeti,P.parcaAdeti) as toplamParcaMaliyet,U.urunKodu,S.siparisKodu, M.malzemeTuru, M.malzemeAdi " +
                    "FROM tblParca P LEFT JOIN tblMalzeme M ON P.malzemeID = M.malzemeID, tblUrun U, tblSiparis S " +
                    "where P.urunID = U.urunID and U.siparisID = S.siparisID and P.parcaID = @ParcaID", baglanti);
                komut.Parameters.Add("@ParcaID", SqlDbType.Int).Value = (parcaId);//parcaId yazılacak
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    prc.parcaId = Convert.ToInt32(read["parcaID"]);
                    prc.malzemeId = Convert.ToInt32(read["malzemeID"]);
                    prc.malzemeTuru = (read["malzemeTuru"]).ToString();
                    prc.malzemeAdi = (read["malzemeAdi"]).ToString();
                    prc.en = float.Parse(read["en"].ToString());
                    prc.boy = float.Parse(read["boy"].ToString());
                    prc.adet = Convert.ToInt32(read["parcaAdeti"]);
                    prc.boya = (read["boya"]).ToString();
                    if (prc.boya == "-")
                    {
                        chckBoxBoya.Checked = false;
                        cmbBoxBoya.Text = "";
                    }
                    else
                    {
                        chckBoxBoya.Checked = true;
                        cmbBoxBoya.Text = prc.boya;
                    }
                    prc.parcaFiyat = Convert.ToDouble(read["parcaMaliyeti"]);
                    txtBoxToplamParcaMaliyeti.Text = read["toplamParcaMaliyet"].ToString();
                    eskiParcaFiyat = prc.parcaFiyat;
                    string siparisKodu = read["siparisKodu"].ToString();
                    lblSiparisAdiKodu.Text = siparisAdi + " / " + siparisKodu;
                    string urunKodu = read["urunKodu"].ToString();
                    lblUrunAdiKodu.Text = urunAdi + " / " + urunKodu;
                }

                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
            lblParcaId.Text = prc.parcaId.ToString();
            cmbBoxMalzemeTuru.Text = prc.malzemeTuru;
            cmbBoxMalzemeAdi.Text = prc.malzemeAdi;
            txtBoxParcaMaliyeti.Text = prc.parcaFiyat.ToString();
            txtBoxEn.Text = prc.en.ToString();
            txtBoxBoy.Text = prc.boy.ToString();
            cmbBoxBoya.Text = prc.boya;
            txtBoxParcaAdeti.Text = prc.adet.ToString();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ParcaListeleFrm prclstlFrm = new Forms.ParcaListeleFrm();
            prclstlFrm.siparisId = this.siparisId;
            prclstlFrm.siparisAdi = this.siparisAdi;
            prclstlFrm.urunAdi = this.urunAdi;
            prclstlFrm.urunId = this.urunId;
            prclstlFrm.Closed += (s, args) => this.Close();
            prclstlFrm.Show();
        }

        private void chckBoxBoya_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxBoya.Checked)
            {
                cmbBoxBoya.Enabled = true;
            }
            else
            {
                cmbBoxBoya.Enabled = false;
            }
        }

        private void parcaMaliyetHesapla(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                double parcaAlan = (Convert.ToDouble(txtBoxEn.Text) / 1000) * (Convert.ToDouble(txtBoxBoy.Text) / 1000);
                double parcaFiyat = (parcaAlan * malzemeBirimFiyat);
                txtBoxParcaMaliyeti.Text = parcaFiyat.ToString();
                txtBoxToplamParcaMaliyeti.Text = (parcaFiyat * Convert.ToInt32(txtBoxParcaAdeti.Text)).ToString();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE tblParca SET urunID = @urunID, malzemeID = @malzemeID, en = @en, boy = @boy, parcaAdeti = @parcaAdeti, boya = @boya, parcaMaliyeti = @parcaMaliyeti where parcaID = @ID", baglanti);
                    komut.Parameters.Add("@urunID", SqlDbType.Int).Value = (urunId);
                    komut.Parameters.Add("@malzemeID", SqlDbType.Int).Value = (malzemeId);
                    komut.Parameters.Add("@en", SqlDbType.Float).Value = (txtBoxEn.Text);
                    komut.Parameters.Add("@boy", SqlDbType.Float).Value = (txtBoxBoy.Text);
                    komut.Parameters.Add("@parcaAdeti", SqlDbType.Int).Value = (txtBoxParcaAdeti.Text);
                    if (chckBoxBoya.Checked)
                    {
                        komut.Parameters.Add("@boya", SqlDbType.NVarChar).Value = (cmbBoxBoya.Text);
                    }
                    else
                    {
                        komut.Parameters.Add("@boya", SqlDbType.NVarChar).Value = ("-");
                    }
                    komut.Parameters.Add("@parcaMaliyeti", SqlDbType.Float).Value = (txtBoxParcaMaliyeti.Text);
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(lblParcaId.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Parça Başarıyla Güncellenmiştir.");
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
                    SqlCommand komut = new SqlCommand("UPDATE tblUrun SET toplamMaliyet = (toplamMaliyet-@eskiFiyat*urunAdeti)+(@yeniFiyat*urunAdeti), guncellemeTarihi = @guncellemeTarihi where urunID = @ID", baglanti);
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = (this.urunId);
                    komut.Parameters.Add("@eskiFiyat", SqlDbType.Float).Value = (eskiParcaFiyat);
                    komut.Parameters.Add("@yeniFiyat", SqlDbType.Float).Value = Convert.ToDouble(txtBoxParcaMaliyeti.Text);
                    komut.Parameters.Add("@guncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
        public bool txtBoxKontrol()
        {
            if (txtBoxParcaAdeti.Text == "" || txtBoxParcaMaliyeti.Text == "" || txtBoxEn.Text == "" || txtBoxBoy.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void cmbBoxMalzemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbBoxMalzemeAdi.Items.Clear();
                baglanti.Open();
                //sectigimiz malzeme türüne göre malzemeleri çağırıyor, malzemeAdi comboBox ımıza o türdeki malzemeleri ekliyor.
                SqlCommand komut = new SqlCommand("Select malzemeAdi from tblMalzeme where malzemeTuru = @malzemeTuru", baglanti);
                komut.Parameters.Add("@malzemeTuru", SqlDbType.NVarChar).Value = (cmbBoxMalzemeTuru.Text);
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

        private void cmbBoxMalzemeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select malzemeID,birimFiyat from tblMalzeme where malzemeAdi = @malzemeAdi", baglanti);
                komut.Parameters.Add("@malzemeAdi", SqlDbType.NVarChar).Value = (cmbBoxMalzemeAdi.Text);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    malzemeId = Convert.ToInt32(read["malzemeID"]);
                    malzemeBirimFiyat = Convert.ToDouble(read["birimFiyat"]);
                    txtBoxParcaMaliyeti.Text = malzemeBirimFiyat.ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
