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
    public partial class MacDavetiGonder : Form
    {
        public MacDavetiGonder()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");

        private void MacDavetiGonder_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec halisahaBilgisi 'Açık' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSaha.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Datagriddeki seçili satırın 0 indeksli sütunundaki veriyi çeker.
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd";
            
            SqlCommand cmd = new SqlCommand("exec ekleMacDaveti '"+txtGonderen.Text+"','"+txtKime.Text+"','" + dateTimePicker1.Value.ToString(format) + " " + dateTimePicker2.Text + "','"+txtSaha.Text+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Başarılı");
            this.Close();
        }
    }
}
