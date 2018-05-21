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
            // TODO: This line of code loads data into the 'futbolDataSet.SahaTuru' table. You can move, or remove it, as needed.
            this.sahaTuruTableAdapter.Fill(this.futbolDataSet.SahaTuru);


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from iller ORDER BY isim ASC ", conn);
            da.Fill(dt);
            cmbil.ValueMember = "il_no";
            cmbil.DisplayMember = "isim";
            cmbil.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Uyeler  where YetkiKodu='2'  ORDER BY KullaniciAdi", conn);
            da2.Fill(dt2);
            cmbUye.ValueMember = "OyuncuId";
            cmbUye.DisplayMember = "KullaniciAdi";
            cmbUye.DataSource = dt2;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Saha values ('" + txtSahaAdi.Text + "','" + cmbSaha.SelectedValue + "','" + cmbil.SelectedValue.ToString() + "','" + cmbilce.SelectedValue.ToString() + "','" + txtAdres.Text + "','a','"+cmbUye.SelectedValue.ToString()+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Başarılı");
        }
    }
}
