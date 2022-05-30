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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QHU8769;Initial Catalog=AyEczanesi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string kad = textKullanıcıAd.Text;
                string sifre = textSifre.Text;
                komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM PersonelGiris WHERE KullanıcıAd='" + textKullanıcıAd.Text + "' AND Sifre='" + textSifre.Text + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ!");
                }

                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex);

            }
        }

    }
}
