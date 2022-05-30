using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkanAydoganProje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QHU8769;Initial Catalog=AyEczanesi;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ayEczanesiDataSet.HastaKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaKayitTableAdapter.Fill(this.ayEczanesiDataSet.HastaKayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kayıt için gerekli alanları doldurunuz!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Kayıt için gerekli alanları doldurunuz!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Kayıt için gerekli alanları doldurunuz!");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Kayıt için gerekli alanları doldurunuz!");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Kayıt için gerekli alanları doldurunuz!");
            }
            else
            {
                //KAYIT BUTONU
                SqlCommand kayıtkomut = new SqlCommand();
                baglanti.Open();
                kayıtkomut.Connection = baglanti;
                kayıtkomut.CommandType = CommandType.StoredProcedure;
                kayıtkomut.CommandText = "sp_kayit";
                kayıtkomut.Parameters.Add("@HastaAd", SqlDbType.VarChar, 30).Value = textBox1.Text;
                kayıtkomut.Parameters.Add("@HastaSoyad", SqlDbType.VarChar, 30).Value = textBox2.Text;
                kayıtkomut.Parameters.Add("@TCKimlik", SqlDbType.Char, 11).Value = textBox3.Text;
                kayıtkomut.Parameters.Add("@Tel", SqlDbType.Char, 11).Value = textBox4.Text;
                kayıtkomut.Parameters.Add("@Adres", SqlDbType.VarChar, 200).Value = textBox5.Text;
                kayıtkomut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SİL BUTONU
            SqlCommand silkomut = new SqlCommand();
            baglanti.Open();
            silkomut.Connection = baglanti;
            silkomut.CommandType = CommandType.StoredProcedure;
            silkomut.CommandText = "sp_sil";
            silkomut.Parameters.Add("@TCKimlik", SqlDbType.Char, 11);
            silkomut.Parameters["@TCKimlik"].Value = textBox3.Text;
            silkomut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi.");
            baglanti.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //GÜNCELLE BUTONU
            SqlCommand guncellekomut = new SqlCommand();
            baglanti.Open();
            guncellekomut.Connection = baglanti;
            guncellekomut.CommandType = CommandType.StoredProcedure;
            guncellekomut.CommandText = "sp_guncelle";
            guncellekomut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            guncellekomut.Parameters.AddWithValue("@HastaAd", textBox1.Text);
            guncellekomut.Parameters.AddWithValue("@HastaSoyad", textBox2.Text);
            guncellekomut.Parameters.AddWithValue("@TCKimlik", textBox3.Text);
            guncellekomut.Parameters.AddWithValue("@Tel", textBox4.Text);
            guncellekomut.Parameters.AddWithValue("@Adres", textBox5.Text);
            guncellekomut.ExecuteNonQuery();
            SqlCommand listele = new SqlCommand("SELECT * FROM HastaKayit", baglanti);
            listele.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //HASTA ADINA GÖRE BUTONU
            baglanti.Open();
            SqlCommand aramakomut = new SqlCommand();
            aramakomut.Connection = baglanti;
            aramakomut.CommandType = CommandType.StoredProcedure;
            aramakomut.CommandText = "sp_arama";
            aramakomut.Parameters.Add("@HastaAd", SqlDbType.VarChar, 30);
            aramakomut.Parameters["@HastaAd"].Value = textBox6.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(aramakomut);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TC KİMLİK NO YA GÖRE ARAMA BUTONU
            baglanti.Open();
            SqlCommand aramakomut = new SqlCommand();
            aramakomut.Connection = baglanti;
            aramakomut.CommandType = CommandType.StoredProcedure;
            aramakomut.CommandText = "sp_aramatc";
            aramakomut.Parameters.Add("@TCKimlik", SqlDbType.Char, 11);
            aramakomut.Parameters["@TCKimlik"].Value = textBox7.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(aramakomut);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
