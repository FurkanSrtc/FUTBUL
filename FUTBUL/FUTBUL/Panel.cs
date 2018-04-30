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
    public partial class Panel : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Futbol; Integrated Security = True");



        public Panel()
        {
            InitializeComponent();
           
           
        }
        DataTable tbl = new DataTable();
        SqlDataAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'futbolDataSet.SahaDurumu' table. You can move, or remove it, as needed.
            this.sahaDurumuTableAdapter.Fill(this.futbolDataSet.SahaDurumu);
            // TODO: This line of code loads data into the 'futbolDataSet.Takimlar' table. You can move, or remove it, as needed.
            this.takimlarTableAdapter.Fill(this.futbolDataSet.Takimlar);

        }

        private void temizle()
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            tbl = new DataTable();
             adapter = new SqlDataAdapter("Select Personel.Adi 'Personel Adı',Personel.Soyadi, Saha.SahaAdi, Saha.Adres, SahaTuru.SahaTuru from Saha Inner Join SahaTuru ON Saha.SahaTuru=SahaTuru.SahaId Inner Join Personel On Saha.SahaNo = Personel.SahaNo", conn);
            adapter.Fill(tbl);
         
            conn.Close();
     
            dataGridView1.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            tbl = new DataTable();
            adapter = new SqlDataAdapter("Select s.SahaAdi, st.SahaTuru,s.il,s.ilce, sd.SahaDurum from Saha s inner join SahaTuru st on s.SahaTuru=st.SahaId inner join SahaDurumu sd on s.SahaDurumu=sd.DurumKodu", conn);
            adapter.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            tbl = new DataTable();
            adapter = new SqlDataAdapter("select o.Ad , o.Soyad, o.FormaNo, t.TakimAdi  from Oyuncular o LEFT JOIN Takimlar t ON o.TakimNo=t.TakimNo", conn);
            adapter.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
             
                conn.Open();
                tbl = new DataTable();
                adapter = new SqlDataAdapter("exec takımBilgisi '" + comboBox1.SelectedValue.ToString() + "'", conn);
                adapter.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }
            catch (Exception)
            {

                
            }
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tbl = new DataTable();
                adapter = new SqlDataAdapter("exec halisahaBilgisi '" + comboBox2.SelectedValue.ToString() + "'", conn);
                adapter.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }
            catch (Exception)
            {

                
            }
          
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            tbl = new DataTable();
            adapter = new SqlDataAdapter("exec pUyeler", conn);
            adapter.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UyeGirisi ug = new UyeGirisi();
                ug.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TakimOlustur takim = new TakimOlustur();
            takim.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TakimaKatil tk = new TakimaKatil();
            tk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BasvuruOnay bo = new BasvuruOnay();
            bo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SahaEkle sh = new SahaEkle();
            sh.Show();
        }
    }
}
