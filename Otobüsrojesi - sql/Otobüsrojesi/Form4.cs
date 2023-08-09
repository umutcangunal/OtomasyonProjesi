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

namespace Otobüsrojesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            //sifre degıstırme guncelleme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set Sifre='" + textBox4.Text + "' where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Şifre Güncellendi");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //gereklı verılerı yazdırma
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
           SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int sira = listView1.Items.Count;

                textBox1.Text = oku["AD"].ToString();
                textBox2.Text = oku["SOYAD"].ToString();
                textBox3.Text = oku["K_adi"].ToString();
                textBox4.Text = oku["Sifre"].ToString();
                textBox5.Text = oku["TELEFON"].ToString();

                pictureBox1.ImageLocation = oku["Resim_url"].ToString();

                listView1.Items.Add(oku["TARİH"].ToString());
                listView1.Items[sira].SubItems.Add(oku["NEREDEN"].ToString());
                listView1.Items[sira].SubItems.Add(oku["NEREYE"].ToString());
                listView1.Items[sira].SubItems.Add(oku["fiyat"].ToString());
            }
            baglantı.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //resım ekleme
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;


            }
            //veritabannına resım url atma
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set Resim_url='" + pictureBox1.ImageLocation + "' where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Resim eklendi.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 giris = new Form3();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 biletgiris = new Form7();
            biletgiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 sorusor = new Form9();
            sorusor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 mail = new Form10();
            mail.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
