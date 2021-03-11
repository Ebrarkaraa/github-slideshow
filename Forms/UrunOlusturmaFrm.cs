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
    public partial class UrunOlusturmaFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);

        MaterialSkinManager skinManager;
        public UrunOlusturmaFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public int siparisId;
        public string siparisAdi;
        private void UrunOlusturmaFrm_Load(object sender, EventArgs e)
        {

        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {

                DateTime localTime = DateTime.Now;
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("urunEkle", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("siparisID", siparisId);
                    komut.Parameters.AddWithValue("kullaniciID", Properties.Settings.Default.kullaniciID);
                    komut.Parameters.AddWithValue("urunKodu", txtBoxUrunKodu.Text);
                    komut.Parameters.AddWithValue("urunAdi", txtBoxUrunAdi.Text);
                    komut.Parameters.AddWithValue("urunBasiSure", txtBoxUrunBasiSure.Text);
                    komut.Parameters.AddWithValue("urunAdeti", txtBoxAdet.Text);
                    komut.Parameters.AddWithValue("toplamMaliyet", 0);
                    komut.Parameters.AddWithValue("guncellemeTarihi", Convert.ToDateTime(localTime.ToString("dd/MM/yyyy HH:mm:ss")));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün başarıyla eklenmiştir.");
                    this.Hide();
                    Forms.UrunListelemeFrm urnLstlFrm = new Forms.UrunListelemeFrm();
                    urnLstlFrm.siparisId = this.siparisId;
                    urnLstlFrm.siparisAdi = this.siparisAdi;
                    urnLstlFrm.FormClosed += (s, args) => this.Close();
                    urnLstlFrm.Show();
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
            Forms.UrunListelemeFrm urnLstlFrm = new Forms.UrunListelemeFrm();
            urnLstlFrm.siparisId = this.siparisId;
            urnLstlFrm.siparisAdi = this.siparisAdi;
            urnLstlFrm.Closed += (s, args) => this.Close();
            urnLstlFrm.Show();
        }
        public bool txtBoxKontrol()
        {
            if (txtBoxUrunKodu.Text == "" || txtBoxUrunAdi.Text == "" || txtBoxUrunBasiSure.Text == "" ||
                txtBoxAdet.Text == "")
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
