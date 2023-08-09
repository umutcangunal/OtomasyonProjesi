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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        static public string eposta;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            // veritabanına ekleme soruyu
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into mesajlar(ad,kullaniciid,soyad,eposta,telefon,adres,konu,ileti) values('" + textBox_ad.Text + "'," + Convert.ToInt32(Form3.id) + ",'" + textBox_soyad.Text + "','" + textBox_tel.Text + "','" + textBox_eposta.Text + "','" + richTextBox_adres.Text + "','" + richTextBox_konu.Text + "','" + richTextBox_ileti.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            eposta = textBox_eposta.Text;
            MessageBox.Show("MESAJINIZ ALINDI EN KISA ZAMANDA YANIT VERİCELECEKTİR");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 kullanıcı = new Form4();
            kullanıcı.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
