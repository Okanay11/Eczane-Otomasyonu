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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QHU8769;Initial Catalog=AyEczanesi;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'firmalardataset.Firmalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmalarTableAdapter.Fill(this.firmalardataset.Firmalar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Close();   
            fr4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kayıtkomut = new SqlCommand();
            baglanti.Open();
            kayıtkomut.Connection = baglanti;
            kayıtkomut.CommandType = CommandType.StoredProcedure;
            kayıtkomut.CommandText = "sp_firmakayit";
            kayıtkomut.Parameters.Add("@FirmaAdlar", SqlDbType.VarChar, 50).Value = textBox1.Text;
            kayıtkomut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = dateTimePicker1.Text;
            kayıtkomut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Firma Kayıt Edildi.");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand firmasilkomut = new SqlCommand();
            baglanti.Open();
            firmasilkomut.Connection = baglanti;
            firmasilkomut.CommandType = CommandType.StoredProcedure;
            firmasilkomut.CommandText = "sp_firmasil";
            firmasilkomut.Parameters.Add("@FirmaAdlar", SqlDbType.VarChar, 50);
            firmasilkomut.Parameters["@FirmaAdlar"].Value = textBox1.Text;
            firmasilkomut.ExecuteNonQuery();
            MessageBox.Show("Firma Silindi.");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand firmaguncellekomut = new SqlCommand();
            baglanti.Open();
            firmaguncellekomut.Connection = baglanti;
            firmaguncellekomut.CommandType = CommandType.StoredProcedure;
            firmaguncellekomut.CommandText = "sp_firmaguncelle";
            firmaguncellekomut.Parameters.AddWithValue("@fId", dataGridView1.CurrentRow.Cells[0].Value);
            firmaguncellekomut.Parameters.AddWithValue("@FirmaAdlar", textBox1.Text);
            firmaguncellekomut.Parameters.AddWithValue("@GirisTarihi", Convert.ToDateTime(dateTimePicker1.Text));
            firmaguncellekomut.ExecuteNonQuery();
            SqlCommand firmalistele = new SqlCommand("SELECT * FROM Firmalar", baglanti);
            firmalistele.ExecuteNonQuery();
            MessageBox.Show("Güncellendi.");
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand firmaaramakomut = new SqlCommand();
            firmaaramakomut.Connection = baglanti;
            firmaaramakomut.CommandType = CommandType.StoredProcedure;
            firmaaramakomut.CommandText = "sp_firmaarama";
            firmaaramakomut.Parameters.Add("@FirmaAdlar", SqlDbType.VarChar, 50);
            firmaaramakomut.Parameters["@FirmaAdlar"].Value = textBox3.Text;
            SqlDataAdapter firmaDa = new SqlDataAdapter(firmaaramakomut);
            DataTable firmadt = new DataTable();
            firmaDa.Fill(firmadt);
            dataGridView1.DataSource = firmadt;
            baglanti.Close();
        }
    }
}
