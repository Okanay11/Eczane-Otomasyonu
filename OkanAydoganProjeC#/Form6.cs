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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QHU8769;Initial Catalog=AyEczanesi;Integrated Security=True");

        public void listele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReceteSatis", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["HastaTc"].ToString());
                item.SubItems.Add(dr["IlacAdi"].ToString());
                item.SubItems.Add(dr["Tarih"].ToString());
                item.SubItems.Add(dr["Adet"].ToString());
                item.SubItems.Add(dr["FaturaNo"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand recetekayıtkomut = new SqlCommand();
            baglanti.Open();
            recetekayıtkomut.Connection = baglanti;
            recetekayıtkomut.CommandType = CommandType.StoredProcedure;
            recetekayıtkomut.CommandText = "sp_recetesatis";
            recetekayıtkomut.Parameters.Add("@HastaTC", SqlDbType.Char, 11).Value = ComboBox1.Text;
            recetekayıtkomut.Parameters.Add("@IlacAdi", SqlDbType.VarChar, 50).Value = ComboBox2.Text;
            recetekayıtkomut.Parameters.Add("@Tarih", SqlDbType.Date).Value = DateTimePicker1.Text;
            recetekayıtkomut.Parameters.Add("@IlacAdet", SqlDbType.TinyInt).Value = TextBox1.Text;
            recetekayıtkomut.Parameters.Add("@FaturaNo", SqlDbType.VarChar, 20).Value = TextBox2.Text;
            recetekayıtkomut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Satış Başarılı.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            /*SqlCommand receteguncellekomut = new SqlCommand();
            baglanti.Open();
            receteguncellekomut.Connection = baglanti;
            receteguncellekomut.CommandType = CommandType.StoredProcedure;
            receteguncellekomut.CommandText = ("sp_receteguncelle");
            receteguncellekomut.Parameters.AddWithValue("@rId", listView1.SelectedItems[0].Index);
            receteguncellekomut.Parameters.AddWithValue("@HastaTc", ComboBox1.Text);
            receteguncellekomut.Parameters.AddWithValue("@IlacAdi", ComboBox2.Text);
            receteguncellekomut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTimePicker1.Text));
            receteguncellekomut.Parameters.AddWithValue("@IlacAdet", TextBox1.Text);
            receteguncellekomut.Parameters.AddWithValue("@FaturaNo", TextBox2.Text);
            receteguncellekomut.ExecuteNonQuery();
            SqlCommand recetelistele = new SqlCommand("SELECT * FROM ReceteSatis", baglanti);
            recetelistele.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Reçete Güncellendi.");*/
            SqlCommand receteguncellekomut = new SqlCommand();
            baglanti.Open();
            receteguncellekomut.Connection = baglanti;
            receteguncellekomut.CommandType = CommandType.StoredProcedure;
            receteguncellekomut.CommandText = "sp_receteguncelle";
            receteguncellekomut.Parameters.Add("@rId", SqlDbType.Int);
            receteguncellekomut.Parameters.Add("@HastaTc", SqlDbType.Char, 11);
            receteguncellekomut.Parameters.Add("@IlacAdi", SqlDbType.VarChar, 50);
            receteguncellekomut.Parameters.Add("@Tarih", SqlDbType.Date);
            receteguncellekomut.Parameters.Add("@IlacAdet", SqlDbType.TinyInt);
            receteguncellekomut.Parameters.Add("@FaturaNo", SqlDbType.VarChar, 20);
            //textboxtan veri alalım
            receteguncellekomut.Parameters["@rId"].Value = Convert.ToInt32(textBox3.Text);
            receteguncellekomut.Parameters["@HastaTc"].Value = ComboBox1.Text;
            receteguncellekomut.Parameters["@IlacAdi"].Value = ComboBox2.Text;
            receteguncellekomut.Parameters["@Tarih"].Value = DateTimePicker1.Text;
            receteguncellekomut.Parameters["@IlacAdet"].Value = TextBox1.Text;
            receteguncellekomut.Parameters["@FaturaNo"].Value = TextBox2.Text;
            receteguncellekomut.ExecuteNonQuery(); 
            MessageBox.Show("Reçete Güncellendi.");
            baglanti.Close(); 
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand recetesilkomut = new SqlCommand();
            baglanti.Open();
            recetesilkomut.Connection = baglanti;
            recetesilkomut.CommandType = CommandType.StoredProcedure;
            recetesilkomut.CommandText = "sp_recetesil";
            recetesilkomut.Parameters.Add("@FaturaNo", SqlDbType.Char, 11);
            recetesilkomut.Parameters["@FaturaNo"].Value = TextBox2.Text;
            recetesilkomut.ExecuteNonQuery();
            MessageBox.Show("Reçete Silindi.");
            baglanti.Close();
            listele();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();   
            this.Close();  
            fr2.Show();   
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listele();
            listView1.View = View.Details;
            // TODO: Bu kod satırı 'ilacDataSet1.IlacEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilacEkleTableAdapter.Fill(this.ilacDataSet1.IlacEkle);
            // TODO: Bu kod satırı 'ayEczanesiDataSet.HastaKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaKayitTableAdapter.Fill(this.ayEczanesiDataSet.HastaKayit);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "TC Kimlik")
            {
                baglanti.Open();
                listView1.Items.Clear();
                SqlCommand rfnaramakomut = new SqlCommand("SELECT*FROM ReceteSatis WHERE HastaTc LIKE'" + TextBox6.Text + "'", baglanti);
                SqlDataReader rctDr = rfnaramakomut.ExecuteReader();
                ListViewItem item = new ListViewItem();
                while (rctDr.Read())
                {
                    item.Text = rctDr["id"].ToString();
                    item.SubItems.Add(rctDr["HastaTc"].ToString());
                    item.SubItems.Add(rctDr["IlacAdi"].ToString());
                    item.SubItems.Add(rctDr["Tarih"].ToString());
                    item.SubItems.Add(rctDr["Adet"].ToString());
                    item.SubItems.Add(rctDr["FaturaNo"].ToString());
                    listView1.Items.Add(item);
                }
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                listView1.Items.Clear();
                SqlCommand rfnaramakomut = new SqlCommand("SELECT*FROM ReceteSatis WHERE FaturaNo LIKE'" + TextBox6.Text + "'", baglanti);
                SqlDataReader rc2tDr = rfnaramakomut.ExecuteReader();
                ListViewItem item = new ListViewItem();
                while (rc2tDr.Read())
                {
                    item.Text = rc2tDr["id"].ToString();
                    item.SubItems.Add(rc2tDr["HastaTc"].ToString());
                    item.SubItems.Add(rc2tDr["IlacAdi"].ToString());
                    item.SubItems.Add(rc2tDr["Tarih"].ToString());
                    item.SubItems.Add(rc2tDr["Adet"].ToString());
                    item.SubItems.Add(rc2tDr["FaturaNo"].ToString());
                    listView1.Items.Add(item);
                }
                baglanti.Close();
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
            ComboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            ComboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            DateTimePicker1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TextBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
           
        }
    }
}
