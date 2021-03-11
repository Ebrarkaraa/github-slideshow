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
using System.IO;
using System.IO.Compression;
using MaterialSkin;

namespace ProjeTakipveHesaplama.Forms
{
    public partial class ParcaListeleFrm : MaterialSkin.Controls.MaterialForm
    {
        public static string connectionSource = Properties.Settings.Default.FabrikaYonetimConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public ParcaListeleFrm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        public int urunId;
        public string urunAdi;
        public int siparisId;
        public string siparisAdi;
        bool selected = false;
        private void ParcaListeleFrm_Load(object sender, EventArgs e)
        {
            lblUrunAdi.Text = this.urunAdi;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1SutunEkle("Parça ID", 60,
                "Malzeme ID", 60,
                "Malzeme Türü", 110,
                "Malzeme Adı", 110,
                "En", 50,
                "Boy", 50,
                "Adet", 50,
                "Boya", 70,
                "Parça Maliyeti", 80);
            listView1Listele();


        }
        public void listView1Listele()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select U.urunAdi,P.*,M.malzemeTuru,M.malzemeAdi from tblUrun U, tblParca P, tblMalzeme M where U.urunID = P.urunID and M.malzemeID = P.MalzemeID and U.urunID = @UrunId", baglanti);
                komut.Parameters.Add("@UrunId", SqlDbType.Int).Value = (urunId);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = read["parcaID"].ToString();
                    ekle.SubItems.Add(read["malzemeID"].ToString());
                    ekle.SubItems.Add(read["malzemeTuru"].ToString());
                    ekle.SubItems.Add(read["malzemeAdi"].ToString());
                    ekle.SubItems.Add(read["en"].ToString());
                    ekle.SubItems.Add(read["boy"].ToString());
                    ekle.SubItems.Add(read["parcaAdeti"].ToString());
                    ekle.SubItems.Add(read["boya"].ToString());
                    ekle.SubItems.Add(read["parcaMaliyeti"].ToString());
                    listView1.Items.Add(ekle);
                    lblUrunAdi.Text = read["urunAdi"].ToString();
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
        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            HesaplamaFrm hsplmFrm = new HesaplamaFrm();
            hsplmFrm.urunId = this.urunId;
            hsplmFrm.siparisAdi = this.siparisAdi;
            hsplmFrm.siparisID = this.siparisId;
            hsplmFrm.Closed += (s, args) => this.Close();
            hsplmFrm.Show();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM tblParca WHERE parcaID = @ParcaID", baglanti);
                    komut.Parameters.Add("@ParcaID", SqlDbType.Int).Value = (listView1.SelectedItems[0].SubItems[0].Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Parça Silinmiştir.");
                    selected = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE tblUrun SET toplamMaliyet = toplamMaliyet-(@ekMaliyet*urunAdeti) where urunID = @ID", baglanti);
                    komut.Parameters.Add("@ID", SqlDbType.Int).Value = (this.urunId);
                    komut.Parameters.Add("@ekMaliyet", SqlDbType.Float).Value = (listView1.SelectedItems[0].SubItems[8].Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                listView1Listele();
            }
            else
            {
                MessageBox.Show("Lütfen bir parça seçiniz!");
            }
        }

        private void btnAyrintiGoster_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                this.Hide();
                Forms.ParcaAyrintiFrm prcAyrntFrm = new Forms.ParcaAyrintiFrm();
                prcAyrntFrm.siparisAdi = this.siparisAdi;
                prcAyrntFrm.siparisId = this.siparisId;
                prcAyrntFrm.urunId = this.urunId;
                prcAyrntFrm.urunAdi = this.urunAdi;
                prcAyrntFrm.parcaId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                prcAyrntFrm.Closed += (s, args) => this.Close();
                prcAyrntFrm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir parça seçiniz.");
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

        private void UrunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.UrunListelemeFrm urnLstFrm = new Forms.UrunListelemeFrm();
            urnLstFrm.siparisAdi = this.siparisAdi;
            urnLstFrm.siparisId = this.siparisId;
            urnLstFrm.Closed += (s, args) => this.Close();
            urnLstFrm.Show();
        }
        private void ürünAyrıntıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.UrunAyrintiFrm urnAyrntFrm = new Forms.UrunAyrintiFrm();
            urnAyrntFrm.urunId = this.urunId;
            urnAyrntFrm.siparisAdi = this.siparisAdi;
            urnAyrntFrm.siparisId = this.siparisId;
            urnAyrntFrm.veriCek();
            urnAyrntFrm.Closed += (s, args) => this.Close();
            urnAyrntFrm.Show();
        }

        private void parçalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ParcaListeleFrm prcLstlFrm = new Forms.ParcaListeleFrm();
            prcLstlFrm.urunId = this.urunId;
            prcLstlFrm.siparisAdi = this.siparisAdi;
            prcLstlFrm.siparisId = this.siparisId;
            prcLstlFrm.Closed += (s, args) => this.Close();
            prcLstlFrm.Show();
        }



    }
}
