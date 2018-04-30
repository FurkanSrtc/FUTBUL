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
    public partial class TakimaKatil : Form
    {

        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");


        public TakimaKatil()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Takimlar where Takimadi LIKE '" + textBox2.Text + "' + '%'", conn);
            adapter.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
           
        }

        private void TakimaKatil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'futbolDataSet.Oyuncular' table. You can move, or remove it, as needed.
            this.oyuncularTableAdapter.Fill(this.futbolDataSet.Oyuncular);
            button1.Enabled = false;
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Takimlar", conn);
            adapter.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }
        string takimkodu = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Datagriddeki seçili satırın 0 indeksli sütunundaki veriyi çeker.
            takimkodu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            DataTable tbl = new DataTable();
            /*  SqlDataAdapter adapter = new SqlDataAdapter("Update Oyuncular set TakimNo = '"+takimkodu+"', FormaNo='"+maskedTextBox1.Text+"'FROM Oyuncular  inner join  Uyeler on Oyuncular.Id = Uyeler.OyuncuId   where Uyeler.OyuncuId = Oyuncular.Id   and Uyeler.KullaniciAdi = '"+ textBox1.Text + "'", conn);  --Takıma Katılır

               */
            SqlDataAdapter adapter = new SqlDataAdapter(" insert into TakimaBasvuru (KullaniciAdi,TakimNo,FormaNo) values ('" + textBox1.Text+"','"+ takimkodu + "','"+ Convert.ToInt16(maskedTextBox1.Text) + "')",conn);
            adapter.Fill(tbl);

            conn.Close();
            MessageBox.Show(textBox2.Text+" Takımına başvuru isteğiniz gönderildi.");
            dataGridView1.DataSource = tbl;

            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
