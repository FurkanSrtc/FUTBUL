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
    public partial class BasvuruOnay : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");

        public BasvuruOnay()
        {
            InitializeComponent();
         
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Datagriddeki seçili satırın 0 indeksli sütunundaki veriyi çeker.
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select KullaniciAdi,FormaNo,TakimNo from TakimaBasvuru where TakimNo LIKE '" + textBox1.Text + "' + '%'", conn);
            adapter.Fill(tbl);

            conn.Close();

            dataGridView1.DataSource = tbl;
        }

        private void BasvuruOnay_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void yenile()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select KullaniciAdi,FormaNo,TakimNo from TakimaBasvuru", conn);
            adapter.Fill(tbl);

            conn.Close();

            dataGridView1.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(" Update Oyuncular set TakimNo = '"+ dataGridView1.CurrentRow.Cells[2].Value.ToString() + "', FormaNo = '"+ dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' FROM Oyuncular inner join Uyeler on Oyuncular.Id = Uyeler.OyuncuId inner join TakimaBasvuru on TakimaBasvuru.KullaniciAdi = Uyeler.KullaniciAdi where Uyeler.OyuncuId = Oyuncular.Id and Uyeler.KullaniciAdi = '"+textBox2.Text+"'", conn);
            adapter.Fill(tbl);

            DataTable tbl2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(" delete from TakimaBasvuru where KullaniciAdi='"+textBox2.Text+"'", conn);
            adapter2.Fill(tbl2);

            MessageBox.Show(textBox2.Text + "Başarıyla Transfer Edildi.");

            conn.Close();
            yenile();
        }
    }
}
