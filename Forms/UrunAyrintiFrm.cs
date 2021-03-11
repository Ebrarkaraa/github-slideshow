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
    public partial class UrunAyrintiFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        Urun urn = new Urun();
        MaterialSkinManager skinManager;
        public UrunAyrintiFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public int urunId;
        public string siparisAdi;
        public int siparisId;

        private void ProjeAyrintiFrm_Load(object sender, EventArgs e)
        {
            veriCek();
        }
        public void veriCek()
        {
            lblUrunID.Text = urunId.ToString();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select U.* from tblUrun U where U.urunID = @UrunId", baglanti);
                komut.Parameters.Add("@UrunId", SqlDbType.Int).Value = (urunId);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    urn.urunId = Convert.ToInt32(read["urunID"]);
                    urn.urunKodu = read["urunKodu"].ToString();
                    urn.urunAdi = read["urunAdi"].ToString();
                    urn.urunBasiSure = Convert.ToInt32(read["urunBasiSure"]);
                    urn.urunAdeti = Convert.ToInt32(read["urunAdeti"]);
                    urn.toplamMaliyet = Convert.ToDouble(read["toplamMaliyet"]);
                }
                read.Close();
                baglanti.Close();

                ayrintiDoldur();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                throw;
            }
        }
        private void ayrintiDoldur()
        {
            lblUrunID.Text = urn.urunId.ToString();
            txtBoxUrunKodu.Text = urn.urunKodu;
            txtBoxUrunAdi.Text = urn.urunAdi;
            txtBoxUrunBasiSure.Text = urn.urunBasiSure.ToString();
            txtBoxAdet.Text = urn.urunAdeti.ToString();
            txtBoxToplamMaliyet.Text = urn.toplamMaliyet.ToString();
        }
        private void parçalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ParcaListeleFrm prcLstFrm = new Forms.ParcaListeleFrm();
            prcLstFrm.urunId = this.urunId;
            prcLstFrm.urunAdi = txtBoxUrunAdi.Text;
            prcLstFrm.siparisId = this.siparisId;
            prcLstFrm.siparisAdi = this.siparisAdi;
            prcLstFrm.Closed += (s, args) => this.Close();
            prcLstFrm.Show();
        }
        private void ürünAyrıntıToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.UrunListelemeFrm urnLstFrm = new Forms.UrunListelemeFrm();
            urnLstFrm.siparisAdi = this.siparisAdi;
            urnLstFrm.siparisId = this.siparisId;
            urnLstFrm.Closed += (s, args) => this.Close();
            urnLstFrm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBoxKontrol())
            {

                DateTime localTime = DateTime.Now;
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE tblUrun SET " +
                        "siparisID = @SiparisID, " +
                        "urunKodu = @UrunKodu, " +
                        "urunAdi = @UrunAdi, " +
                        "urunBasiSure = @UrunBasiSure, " +
                        "urunAdeti = @UrunAdet, " +
                        "toplamMaliyet = @ToplamMaliyet, " +
                        "guncellemeTarihi = @GuncellemeTarihi " +
                        "where urunID = @ID", baglanti);
                    komut.Parameters.Add("@SiparisID", SqlDbType.Int).Value = (this.siparisId);
                    komut.Parameters.Add("@UrunKodu", SqlDbType.NVarChar).Value = (txtBoxUrunKodu.Text);
                    komut.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = (txtBoxUrunAdi.Text);
                    komut.Parameters.Add("@UrunBasiSure", SqlDbType.Int).Value = (txtBoxUrunBasiSure.Text);
                    komut.Parameters.Add("@UrunAdet", SqlDbType.Int).Value = (txtBoxAdet.Text);
                    komut.Parameters.Add("@ToplamMaliyet", SqlDbType.Float).Value = (txtBoxToplamMaliyet.Text);
                    komut.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = (lblUrunID.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün Başarıyla Güncellenmiştir.");
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
            if (txtBoxUrunKodu.Text == "" || txtBoxUrunAdi.Text == "" || txtBoxUrunBasiSure.Text == "" || 
                txtBoxAdet.Text == "" || txtBoxToplamMaliyet.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtBoxAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAdet.Text != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Select DISTINCT dbo.Fn_UrunToplamMaliyet(@urunID)*@urunAdet As ToplamUrunMaliyeti From tblUrun U, tblParca P where U.urunID = P.urunID", baglanti);
                    komut.Parameters.Add("@urunAdet", SqlDbType.Int).Value = (txtBoxAdet.Text);
                    komut.Parameters.Add("@urunID", SqlDbType.Int).Value = (lblUrunID.Text);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        txtBoxToplamMaliyet.Text = read["ToplamUrunMaliyeti"].ToString();
                    }
                    read.Close();
                    baglanti.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
    }
}
