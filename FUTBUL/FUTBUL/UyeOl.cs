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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");
        SqlDataAdapter adapter;
        DataTable tbl;

        private void button1_Click(object sender, EventArgs e)
        {
            // exec pOyuncuEkle 'Murat','Şaşmaz','5555147865'
            try
            {
                conn.Open();
                tbl = new DataTable();
                adapter = new SqlDataAdapter("exec pOyuncuEkle '" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtmaskTel.Text + "','"+textBox1.Text+"','"+textBox2.Text+"','"+cmbYetkiTuru.SelectedValue.ToString()+"'", conn);
                adapter.Fill(tbl);
                conn.Close();
             DialogResult a= MessageBox.Show("Kayıt Ekleme Başarılı\n Ana Menüye Döncek Misin ?", "Başarılı",MessageBoxButtons.YesNo);
                if (a==DialogResult.Yes)
                {
                    /*  Panel p = new Panel();
                      p.Show();*/
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Ekleme Başarısız", "Başarısız");
            }
        
        


        }

        private void UyeOl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'futbolDataSet.Yetkiler' table. You can move, or remove it, as needed.
            this.yetkilerTableAdapter.Fill(this.futbolDataSet.Yetkiler);
            // TODO: This line of code loads data into the 'futbolDataSet.Oyuncular' table. You can move, or remove it, as needed.


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
