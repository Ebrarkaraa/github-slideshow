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
    public partial class UrunListelemeFrm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public UrunListelemeFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        bool selected = false;
        public int siparisId;
        public string siparisAdi;
        private void ProjeListelemeFrm_Load(object sender, EventArgs e)
        {
            lblSiparisAdi.Text = siparisAdi;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1SutunEkle("Ürün ID", 60,
                "Ürün Kodu", 90,
                "Ürün Adı", 110,
                "Ürün Başına Süre(DK)", 120,
                "Ürün Adeti", 70,
                "Toplam Maliyet", 100,
                "Oluşturan Kullanıcı", 100,
                "Güncelleme Tarihi", 100);

            listView1Listele();
        }

        public void listView1Listele()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT U.*, K.kullaniciAdi FROM tblUrun U LEFT JOIN tblKullanici K ON U.kullaniciID = K.kullaniciID WHERE U.siparisID = @SiparisId", baglanti);
                komut.Parameters.Add("@SiparisId", SqlDbType.Int).Value = (siparisId);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["urunID"].ToString();
                    ekle.SubItems.Add(read["urunKodu"].ToString());
                    ekle.SubItems.Add(read["urunAdi"].ToString());
                    ekle.SubItems.Add(read["urunBasiSure"].ToString());
                    ekle.SubItems.Add(read["urunAdeti"].ToString());
                    ekle.SubItems.Add(read["toplamMaliyet"].ToString());
                    ekle.SubItems.Add(read["kullaniciAdi"].ToString());
                    ekle.SubItems.Add(read["guncellemeTarihi"].ToString());
                    listView1.Items.Add(ekle);
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                throw;
            }

        }
        public void listView1SutunEkle(string a, int a1,
            string b, int b1,
            string c, int c1,
            string d, int d1,
            string e, int e1,
            string f, int f1,
            string g, int g1,
            string h, int h1)
        {
            listView1.Columns.Add(a, a1);
            listView1.Columns.Add(b, b1);
            listView1.Columns.Add(c, c1);
            listView1.Columns.Add(d, d1);
            listView1.Columns.Add(e, e1);
            listView1.Columns.Add(f, f1);
            listView1.Columns.Add(g, g1);
            listView1.Columns.Add(h, h1);
        }




        private void btnSil_Click(object sender, EventArgs e)
        {

            if (selected)
            {
                string message = "Ürünü silmek istediğinizden emin misiniz?";
                string title = "UYARI!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM tblUrun WHERE urunID = @UrunID", baglanti);
                        komut.Parameters.Add("@UrunID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Ürün Silinmiştir.");
                        listView1Listele();
                        selected = false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                selected = false;
                return;
            }
            else
            {
                selected = true;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Siparişler sprsLstlFrm = new Forms.Siparişler();
            sprsLstlFrm.Closed += (s, args) => this.Close();
            sprsLstlFrm.Show();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.UrunOlusturmaFrm urunGrsFrm = new Forms.UrunOlusturmaFrm();
            urunGrsFrm.siparisId = this.siparisId;
            urunGrsFrm.siparisAdi = this.siparisAdi;
            urunGrsFrm.FormClosed += (s, args) => this.Close();
            urunGrsFrm.Show();
        }
        private void btnAyrintiGoster_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                this.Hide();
                UrunAyrintiFrm prjAyrntFrm = new UrunAyrintiFrm();
                prjAyrntFrm.urunId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                prjAyrntFrm.siparisId = this.siparisId;
                prjAyrntFrm.siparisAdi = this.siparisAdi;
                prjAyrntFrm.Closed += (s, args) => this.Close();
                prjAyrntFrm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz");
            }

        }
    }
}
