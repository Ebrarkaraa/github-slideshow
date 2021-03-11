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
    public partial class AnaMenu : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        Malzeme mlzm = new Malzeme();
        MaterialSkinManager skinManager;
        public AnaMenu()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.BLACK);
        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
            if (Properties.Settings.Default.girisYetkisi)//girdiği yetkiye göre yetkili kısmı açılıp kapanıcak
            {
                menuStrip1.Items[2].Visible = true;
            }
            else
            {
                menuStrip1.Items[2].Visible = false;
            }
        }
        private void malzemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Malzemefrm mlzmFrm = new Malzemefrm();
            mlzmFrm.Closed += (s, args) => this.Close();
            mlzmFrm.Show();
        }

        private void yetkiliEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkiliFrm ytklFrm = new YetkiliFrm();
            ytklFrm.Closed += (s, args) => this.Close();
            ytklFrm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.GirisKontrolFrm grsFrm = new Forms.GirisKontrolFrm();
            grsFrm.Closed += (s, args) => this.Close();
            grsFrm.Show();
        }
        private void btnSiparisListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Siparişler sprsLstlFrm = new Forms.Siparişler();
            sprsLstlFrm.Closed += (s, args) => this.Close();
            sprsLstlFrm.Show();
        }
        private void btnTaleplerim_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.TalepOlusturmaFrm tlpFrm = new Forms.TalepOlusturmaFrm();
            tlpFrm.Closed += (s, args) => this.Close();
            tlpFrm.Show();
        }

        
    }
}
