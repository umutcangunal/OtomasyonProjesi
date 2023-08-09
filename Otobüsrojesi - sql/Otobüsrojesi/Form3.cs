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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //diger formlardan ulasmak ıcın tanımlandı
        static public int id;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bool kullanıcıvarmi = false;

            // giriş yapma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where K_adi='" + textBox1.Text + "' and Sifre='" + textBox2.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kullanıcıvarmi = true;
                id = Convert.ToInt32(oku["ID"]);
            }
            baglanti.Close();
            if (kullanıcıvarmi)
            {
                MessageBox.Show("Giriş Başarılı");

                Form4 kullanıcı = new Form4();
                kullanıcı.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ansyf = new Form1();
            ansyf.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar.ToString() == "*")
            {
                textBox2.PasswordChar = char.Parse("\0");
                button4.Text = "Gizle";
            }
            else
            {
                textBox2.PasswordChar = char.Parse("*");
                button4.Text = "Göster";
            }
        }
    }
}
