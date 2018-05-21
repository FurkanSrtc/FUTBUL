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

        public void yenile(string kullaniciAdi)
        {
            lblKullaniciAdi.Text = kullaniciAdi; 
        }

        DataTable tbl = new DataTable();
        SqlDataAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'futbolDataSet1.Takimlar' table. You can move, or remove it, as needed.
            this.takimlarTableAdapter.Fill(this.futbolDataSet.Takimlar);
            // TODO: This line of code loads data into the 'futbolDataSet1.SahaDurumu' table. You can move, or remove it, as needed.
            this.sahaDurumuTableAdapter.Fill(this.futbolDataSet.SahaDurumu);
        }

        private void temizle()
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            tbl = new DataTable();
             adapter = new SqlDataAdapter("exec gosterSaha", conn);
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
            adapter = new SqlDataAdapter("exec gosterUyeler", conn);
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
            if (lblKullaniciAdi.Text=="none")
            {
                MessageBox.Show("Lütfen Üye Girişi Yapın", "Hata");
            }
            else { 
            TakimOlustur takim = new TakimOlustur(lblKullaniciAdi.Text);
            takim.Show();
            }
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
           /* conn.Open();
            
            SqlCommand cmd = new SqlCommand("select yetkikodu from Uyeler where KullaniciAdi='"+lblKullaniciAdi.Text+"'",conn);

            if (lblKullaniciAdi.Text!="none")
            {
                MessageBox.Show(cmd.ExecuteScalar().ToString());

                if (cmd.ExecuteScalar().ToString() == "1" || cmd.ExecuteScalar().ToString() == "0")
                {*/
                    SahaEkle sh = new SahaEkle();
                    sh.Show();
            /* }

         }

         else
         {
             MessageBox.Show("'"+lblKullaniciAdi.Text+"' hesabı yetkili değil.\nLütfen Yetkili Hesapla Giriş Yapın","Hata");
         }
         conn.Close();*/
        }



    }
    }

