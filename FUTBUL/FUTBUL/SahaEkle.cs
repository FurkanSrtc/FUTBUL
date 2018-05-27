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

namespace FUTBUL
{
    public partial class SahaEkle : Form
    {
        public SahaEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");

        private void SahaEkle_Load(object sender, EventArgs e)
        {
            this.sahaTuruTableAdapter.Fill(this.futbolDataSet.SahaTuru);
            #region iller
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from iller ORDER BY isim ASC ", conn);
            da.Fill(dt);
            cmbil.ValueMember = "il_no";
            cmbil.DisplayMember = "isim";
            cmbil.DataSource = dt;
            #endregion
            #region ilceler
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Uyeler  where YetkiKodu='2'  ORDER BY KullaniciAdi", conn);
            da2.Fill(dt2);
            cmbUye.ValueMember = "OyuncuId";
            cmbUye.DisplayMember = "KullaniciAdi";
            cmbUye.DataSource = dt2;
            #endregion

            #region Ekstra Özellikler
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SahaEkstraOzellikler ORDER BY EkstraOzellikAdi", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                checkedListBox1.Items.Add(dr["EkstraOzellikAdi"]);
            }
            conn.Close();
            #endregion

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbil.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where il_no = " + cmbil.SelectedValue, conn);
                da.Fill(dt);
                cmbilce.ValueMember = "ilce_no";
                cmbilce.DisplayMember = "isim";
                cmbilce.DataSource = dt;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec ekleHaliSaha'" + txtSahaAdi.Text + "','" + cmbSaha.SelectedValue + "','" + cmbil.SelectedValue.ToString() + "','" + cmbilce.SelectedValue.ToString() + "','" + txtAdres.Text + "','"+cmbUye.SelectedValue.ToString()+"','"+txtUcret.Text+"'",conn);
            cmd.ExecuteNonQuery();
            foreach (CalismaSaati item in secilenGunler)
            {
                SqlCommand cmd2 = new SqlCommand("exec ekleSahaCalismaSaati '"+item.Gun+"','"+item.AcilisSaati+"','"+item.KapanisSaati+"'",conn);
                cmd2.ExecuteNonQuery();
            }
        
            foreach (var item in checkedListBox1.CheckedItems)
            {
             
                    SqlCommand cmd3 = new SqlCommand("exec ekleSahaEkstra '"+item.ToString()+"','"+txtSahaAdi.Text+"'",conn);
                    cmd3.ExecuteNonQuery();
               
            }
            conn.Close();
            MessageBox.Show("Başarılı");
        }

        List<CalismaSaati> secilenGunler = new List<CalismaSaati>();
        private void numericKontrol(CheckBox checkGun,DateTimePicker baslangicSaat, DateTimePicker bitisSaat,Label label)
        {
            if (checkGun.Checked==true)
            {
                CalismaSaati calismaSaati = new CalismaSaati() {
                   Gun=checkGun.Text,
                   AcilisSaati=baslangicSaat.Text,
                   KapanisSaati= bitisSaat.Text };
              
                secilenGunler.Add(calismaSaati);

                baslangicSaat.Visible = true;
                bitisSaat.Visible = true;
                label.Visible = true; //Açılışla kapanış saatleri arasındaki '-' işareti
            }
            else
            {
                CalismaSaati calismaSaati = new CalismaSaati()
                {
                    Gun = checkGun.Text,
                    AcilisSaati = baslangicSaat.Text,
                    KapanisSaati = bitisSaat.Text
                };
                secilenGunler.RemoveAll(a => a.Gun == calismaSaati.Gun);
                baslangicSaat.Visible = false;
                bitisSaat.Visible = false;
                label.Visible = false; //Açılışla kapanış saatleri arasındaki '-' işareti
            }
        }

        private void chkPazartesi_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkPazartesi, BasPazartesi, BitPazartesi, label7);
        }

        private void chkSali_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkSali, BasSalı, BitSalı, label8);
        }

        private void chkCarsamba_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkCarsamba, BasÇarşamba, BitÇarşamba, label9);
        }

        private void chkPersembe_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkPersembe, BasPerşembe, BitPerşembe, label10);
        }

        private void chkCuma_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkCuma, basCuma, BitCuma, label11);
        }

        private void chkCumartesi_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkCumartesi, basCumartesi, BitCumartesi, label12);
        }
        private void chkPazar_CheckedChanged(object sender, EventArgs e)
        {
            numericKontrol(chkPazar, basPazar, BitPazar, label13);
        }
    }
}
