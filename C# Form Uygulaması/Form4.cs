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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QHU8769;Initial Catalog=AyEczanesi;Integrated Security=True");
        public void listele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM IlacEkle", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["Barkod"].ToString());
                item.SubItems.Add(dr["Ad"].ToString());
                item.SubItems.Add(dr["Miktar"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());
                item.SubItems.Add(dr["Firma"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
            listView1.View = View.Details;
            SqlCommand comboboxverikomut = new SqlCommand();
            comboboxverikomut.CommandText = "SELECT  * FROM Firmalar";
            comboboxverikomut.Connection = baglanti;
            comboboxverikomut.CommandType = CommandType.Text;
            SqlDataReader boxdr;
            baglanti.Open();
            boxdr = comboboxverikomut.ExecuteReader();
            while (boxdr.Read())
            {
                comboBox1.Items.Add(boxdr["FirmaAdlar"]);
            }
            baglanti.Close();
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
            else if (comboBox1.Text == "")
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
                kayıtkomut.CommandText = "sp_ilackayit";
                kayıtkomut.Parameters.Add("@Barkod", SqlDbType.Char, 10).Value = textBox1.Text;
                kayıtkomut.Parameters.Add("@Ad", SqlDbType.VarChar, 50).Value = textBox2.Text;
                kayıtkomut.Parameters.Add("@Miktar", SqlDbType.TinyInt).Value = textBox3.Text;
                kayıtkomut.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = textBox4.Text;
                kayıtkomut.Parameters.Add("@Firma", SqlDbType.VarChar, 50).Value = comboBox1.Text;
                kayıtkomut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SİL BUTONU
            SqlCommand ilacsilkomut = new SqlCommand();
            baglanti.Open();
            ilacsilkomut.Connection = baglanti;
            ilacsilkomut.CommandType = CommandType.StoredProcedure;
            ilacsilkomut.CommandText = "sp_ilacsil";
            ilacsilkomut.Parameters.Add("@Barkod", SqlDbType.Char, 11);
            ilacsilkomut.Parameters["@Barkod"].Value = textBox1.Text;
            ilacsilkomut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi.");
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand ilacguncellekomut = new SqlCommand();
            baglanti.Open();
            ilacguncellekomut.Connection = baglanti;
            ilacguncellekomut.CommandType = CommandType.StoredProcedure;
            ilacguncellekomut.CommandText = "sp_ilacguncelle";
            ilacguncellekomut.Parameters.AddWithValue("@Id", textBox5.Text);
            ilacguncellekomut.Parameters.AddWithValue("@Barkod", textBox1.Text);
            ilacguncellekomut.Parameters.AddWithValue("@Ad", textBox2.Text);
            ilacguncellekomut.Parameters.AddWithValue("@Miktar", Convert.ToInt16(textBox3.Text));
            ilacguncellekomut.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(textBox4.Text));
            ilacguncellekomut.Parameters.AddWithValue("@Firma", comboBox1.Text);
            ilacguncellekomut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.");
            baglanti.Close();
            listele();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.titck.gov.tr/dinamikmodul/43");
        }
    }
}
