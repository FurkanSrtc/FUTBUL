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
    public partial class UyeGirisi : Form
    {

       SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");
      
      

        public UyeGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Uyeler where KullaniciAdi='"+textBox1.Text+"' and Sifre='"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count ==0) MessageBox.Show("Kullanıcı Adı veya Parolanız hatalı");

           else MessageBox.Show("Giriş Başarılı");

            conn.Close();
            
        }

        private void UyeGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
