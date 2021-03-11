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
    public partial class SiparisOlusturmaFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public SiparisOlusturmaFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SiparisOlusturmaFrm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.girisYetkisi)
            {
                cmbBoxSiparisBolum.Enabled = true;
                cmbBoxSiparisBolum.Text = cmbBoxSiparisBolum.Items[0].ToString();
            }
            else
            {
                cmbBoxSiparisBolum.Text = Properties.Settings.Default.kullaniciBolum;
            }
            cmbBoxOnayDurumu.Text = "False";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Siparişler sprsLstlFrm = new Forms.Siparişler();
            sprsLstlFrm.FormClosed += (s, args) => this.Close();
            sprsLstlFrm.Show();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
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
                    SqlCommand komut = new SqlCommand("INSERT INTO tblSiparis (kullaniciID,siparisAdi,siparisKodu,onayDurumu,imalatTarihi,sevkTarihi,siparisBolum,guncellemeTarihi) VALUES " +
                        "(@KullaniciID,@SiparisAdi,@SiparisKodu,@OnayDurumu,@ImalatTarihi,@SevkTarihi,@SiparisBolum,@GuncellemeTarihi)", baglanti);
                    komut.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = (Properties.Settings.Default.kullaniciID);
                    komut.Parameters.Add("@SiparisAdi", SqlDbType.NVarChar).Value = (txtBoxSiparisAdi.Text);
                    komut.Parameters.Add("@SiparisKodu", SqlDbType.NVarChar).Value = (txtBoxSiparisKodu.Text);
                    komut.Parameters.Add("@OnayDurumu", SqlDbType.Bit).Value = (false);
                    komut.Parameters.Add("@ImalatTarihi", SqlDbType.DateTime).Value = (dateTimeImalat.Value);
                    komut.Parameters.Add("@SevkTarihi", SqlDbType.DateTime).Value = (dateTimeSevk.Value);
                    komut.Parameters.Add("@SiparisBolum", SqlDbType.NVarChar).Value = (cmbBoxSiparisBolum.Text);
                    komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Sipariş başarıyla eklenmiştir.");
                    this.Hide();
                    Forms.Siparişler sprsLstlFrm = new Forms.Siparişler();
                    sprsLstlFrm.FormClosed += (s, args) => this.Close();
                    sprsLstlFrm.Show();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
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
        public bool txtBoxKontrol()
        {
            if (txtBoxSiparisKodu.Text == "" || txtBoxSiparisAdi.Text == "")
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
