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
    public partial class Siparişler : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public Siparişler()
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
        private void SiparisListeleFrm_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        public void frmLoad()
        {
            selected = false;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Sipariş ID", 70,
                "Sipariş Adı", 110,
                "Sipariş Kodu", 90,
                "Onay Durumu", 100,
                "İmalat Tarihi", 90,
                "Sevk Tarihi", 90,
                "Bölümü", 100,
                "Güncelleyen Kullanıcı", 100,
                "Güncellenme Tarihi", 120);

            listView1Listele();
        }
        public void listView1Listele()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut;
                komut = new SqlCommand("SELECT * FROM siparisler", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    DateTime dt;
                    ekle.Text = (read["siparisID"].ToString());
                    ekle.SubItems.Add(read["siparisAdi"].ToString());
                    ekle.SubItems.Add(read["siparisKodu"].ToString());
                    ekle.SubItems.Add(read["onayDurumu"].ToString());
                    if (Convert.ToBoolean(read["onayDurumu"]))
                    {
                        dt = Convert.ToDateTime(read["imalatTarihi"].ToString());
                        ekle.SubItems.Add(dt.ToString("dd/MM/yyyy"));
                        dt = Convert.ToDateTime(read["sevkTarihi"].ToString());
                        ekle.SubItems.Add(dt.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        ekle.SubItems.Add("-");
                        ekle.SubItems.Add("-");
                    }
                    ekle.SubItems.Add(read["siparisBolum"].ToString());
                    ekle.SubItems.Add(read["kullaniciAdi"].ToString());
                    ekle.SubItems.Add(read["guncellemeTarihi"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglanti.Close();
            }
            catch (Exception)
            {
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
            string h, int h1,
            string i, int i1)
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
        }
        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                this.Hide();
                UrunListelemeFrm urnLstlFrm = new UrunListelemeFrm();
                urnLstlFrm.siparisId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                urnLstlFrm.siparisAdi = (listView1.SelectedItems[0].SubItems[1].Text);
                urnLstlFrm.Closed += (s, args) => this.Close();
                urnLstlFrm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçiniz!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                string message = "Siparişi silmek istediğinizden emin misiniz?";
                string title = "UYARI!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("siparisSil", baglanti);
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("siparisID", Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Sipariş Silinmiştir.");
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
                MessageBox.Show("Lütfen bir sipariş seçiniz!");
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
            AnaMenu anaMenuFrm = new AnaMenu();
            anaMenuFrm.Closed += (s, args) => this.Close();
            anaMenuFrm.Show();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.SiparisOlusturmaFrm sprsOlusturmaFrm = new Forms.SiparisOlusturmaFrm();
            sprsOlusturmaFrm.Closed += (s, args) => this.Close();
            sprsOlusturmaFrm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                selected = false;
                this.Hide();
                Forms.SiparisAyrintiFrm sprsGncllFrm = new Forms.SiparisAyrintiFrm();
                sprsGncllFrm.siparisId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                sprsGncllFrm.Closed += (s, args) => this.Close();
                sprsGncllFrm.Show();
            }
            else
            {
                selected = false;
                MessageBox.Show("Lütfen bir sipariş seçiniz!");
            }

        }

    }
}
