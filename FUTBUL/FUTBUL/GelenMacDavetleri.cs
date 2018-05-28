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
    public partial class GelenMacDavetleri : Form
    {
        public GelenMacDavetleri()
        {
            InitializeComponent();
        }

        private void GelenMacDavetleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'futbolDataSet.Takimlar' table. You can move, or remove it, as needed.
            this.takimlarTableAdapter.Fill(this.futbolDataSet.Takimlar);

        }
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("gosterMacDavetleri '"+comboBox1.Text+"'", conn);
            adapter.Fill(tbl);

            conn.Close();

            dataGridView1.DataSource = tbl;


            dataGridView1.Columns[0].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtAlici.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //Datagriddeki seçili satırın 1 indeksli sütunundaki veriyi çeker.
        }

        private void button1_Click(object sender, EventArgs e)
        {//Onay durumunu 1 yapcak
            string format = "yyyy-MM-dd HH:mm:ss";
            DateTime tarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
           

            SqlCommand cmd = new SqlCommand("exec guncelleMacOnayDurumu1 '"+ dataGridView1.CurrentRow.Cells[0].Value.ToString()+"','"+ 
                tarih.ToString(format) + "', '"+comboBox1.SelectedValue.ToString()+"','"+ dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Başarılı...");
        }
    }
}
