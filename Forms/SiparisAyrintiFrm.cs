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
    public partial class SiparisAyrintiFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public SiparisAyrintiFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        Siparis sprs = new Siparis();
        public int siparisId;
        private void SiparisGuncelleFrm_Load(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblSiparis S where S.siparisID = @SiparisID", baglanti);
                komut.Parameters.Add("@SiparisID", SqlDbType.Int).Value = (siparisId);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    sprs.siparisId = Convert.ToInt32(read["siparisID"]);
                    sprs.siparisKodu = (read["siparisKodu"].ToString());
                    sprs.siparisAdi = (read["siparisAdi"].ToString());
                    sprs.imalatTarihi = (read["imalatTarihi"].ToString());
                    sprs.sevkTarihi = (read["sevkTarihi"].ToString());
                    sprs.onayDurumu = Convert.ToBoolean(read["onayDurumu"]);
                    sprs.siparisBolum = (read["siparisBolum"].ToString());
                }
                lblSiparisId.Text = sprs.siparisId.ToString();
                txtBoxSiparisKodu.Text = sprs.siparisKodu;
                txtBoxSiparisAdi.Text = sprs.siparisAdi;
                dateTimeImalat.Value = Convert.ToDateTime(sprs.imalatTarihi);
                dateTimeSevk.Value = Convert.ToDateTime(sprs.sevkTarihi);
                cmbBoxOnayDurumu.Text = sprs.onayDurumu.ToString();
                cmbBoxSiparisBolum.Text = sprs.siparisBolum.ToString();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());

                throw;
            }
            if (!Properties.Settings.Default.girisYetkisi)
            {
                cmbBoxSiparisBolum.Enabled = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoxSiparisKodu.Text != "" && txtBoxSiparisAdi.Text != "")
            {

                if (cmbBoxOnayDurumu.Text == "False")
                {
                    dateTimeImalat.Value = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
                    dateTimeSevk.Value = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
                }
                DateTime localTime = DateTime.Now;

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE tblSiparis SET " +
                        "kullaniciID = @KullaniciID, " +
                        "siparisAdi = @SiparisAdi, " +
                        "siparisKodu = @SiparisKodu, " +
                        "onayDurumu = @OnayDurumu, " +
                        "imalatTarihi = @ImalatTarihi, " +
                        "sevkTarihi = @SevkTarihi, " +
                        "siparisBolum = @SiparisBolum, " +
                        "guncellemeTarihi = @GuncellemeTarihi " +
                        "where siparisID = @ID", baglanti);
                    komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);
                    komut.Parameters.Add("@SiparisAdi", SqlDbType.NVarChar).Value = (txtBoxSiparisAdi.Text);
                    komut.Parameters.Add("@SiparisKodu", SqlDbType.NVarChar).Value = (txtBoxSiparisKodu.Text);
                    komut.Parameters.Add("@OnayDurumu", SqlDbType.Bit).Value = (cmbBoxOnayDurumu.Text);
                    komut.Parameters.Add("@ImalatTarihi", SqlDbType.DateTime).Value = (dateTimeImalat.Value.ToString("dd/MM/yyyy"));
                    komut.Parameters.Add("@SevkTarihi", SqlDbType.DateTime).Value = (dateTimeSevk.Value.ToString("dd/MM/yyyy"));
                    komut.Parameters.Add("@SiparisBolum", SqlDbType.NVarChar).Value = (cmbBoxSiparisBolum.Text);
                    komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = (lblSiparisId.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Sipariş Başarıyla Güncellenmiştir.");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Siparişler sprsLstlFrm = new Forms.Siparişler();
            sprsLstlFrm.Closed += (s, args) => this.Close();
            sprsLstlFrm.Show();
        }

        private void cmbBoxOnayDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxOnayDurumu.Text == "True")
            {
                dateTimeImalat.Enabled = true;
                dateTimeSevk.Enabled = true;
            }
            else
            {
                dateTimeImalat.Enabled = false;
                dateTimeSevk.Enabled = false;
            }
        }
    }
}
