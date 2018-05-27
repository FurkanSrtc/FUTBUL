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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            txtAlici.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Datagriddeki seçili satırın 0 indeksli sütunundaki veriyi çeker.
        }

        private void button1_Click(object sender, EventArgs e)
        {//Onay durumunu 1 yapcak
            SqlCommand cmd = new SqlCommand("", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
