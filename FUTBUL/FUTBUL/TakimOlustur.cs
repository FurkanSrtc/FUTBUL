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
    public partial class TakimOlustur : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");

        public TakimOlustur()
        {
            InitializeComponent();
        }

        private void TakimOlustur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(" Insert into Takimlar Values ('"+textBox1.Text+"','"+textBox2.Text+"')", conn);
            adapter.Fill(tbl);
            conn.Close();

            MessageBox.Show(textBox1.Text + " Takımı Başarıyla Oluşturuldu.");
        }
    }
}
