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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int id;
        static public int sira;
        static public string tarih, nereye;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        public void temizle()
        {

            textBox_isim.Clear();
            textBox_soyisim.Clear();
            textBox_tc.Clear();
            textBox_tel.Clear();
            comboBox_adet.Text = "";
            comboBox_cinsiyet.Text = "";
            comboBox_nereden.Text = "";
            comboBox_nereye.Text = "";
            comboBox_saat.Text = "";
            comboBox_yas.Text = "";


        }
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            //nereye = comboBox_nereye.Text;
            //tarih = dateTimePicker_tarih.Text;

            //veri tabanında guncelleme bilgileri
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set YAŞ='" + comboBox_yas.Text.ToString() + "', TELEFON='" + textBox_tel.Text + "',CİNSİYET='" + comboBox_cinsiyet.Text.ToString() + "',NEREDEN='" + comboBox_nereden.Text.ToString() + "',NEREYE='" + comboBox_nereye.Text.ToString() + "',SAAT='" + comboBox_saat.Text.ToString() + "',ADET='" + comboBox_adet.Text.ToString() + "',TARİH='" + dateTimePicker_tarih.Text.ToString() + "' where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt yapıldı");

            temizle();

            Form8 from8 = new Form8();
            from8.Show();
            this.Hide();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        int fiyat = 0;
        private void comboBox_nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_nereye.Text == "ADANA")
            {
                fiyat = 110;
            }
            if (comboBox_nereye.Text == "ANKARA")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "ANTALYA")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "AYDIN")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "BALIKKESİR")
            {
                fiyat = 100;
            }
            if (comboBox_nereye.Text == "BURSA")
            {
                fiyat = 100;
            }
            if (comboBox_nereye.Text == "DENİZLİ")
            {
                fiyat = 100;
            }
            if (comboBox_nereye.Text == "DİYARBAKIR")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "ERZURUM")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "ESKİŞEHİR")
            {
                fiyat = 100;
            }
            if (comboBox_nereye.Text == "GAZİANTEP")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "HATAY")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "İSTANBUL(AND)")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "İSTANBUL(AVR)")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "İZMİR")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "KAHRAMANMARAŞ")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "KAYSERİ")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "KOCAELİ")
            {
                fiyat = 60;
            }
            if (comboBox_nereye.Text == "KONYA")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "MALATYA")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "MANİSA")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "MERSİN")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "MUĞLA")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "ORDU")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "SAKARYA")
            {
                fiyat = 60;
            }
            if (comboBox_nereye.Text == "SAMSUN")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "ŞANLIURFA")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "TEKİRDAĞ")
            {
                fiyat = 50;
            }
            if (comboBox_nereye.Text == "TRABZON")
            {
                fiyat = 120;
            }
            if (comboBox_nereye.Text == "VAN")
            {
                fiyat = 150;
            }
            if (comboBox_nereye.Text == "GÜRCİSTAN")
            {
                fiyat = 500;
            }
            if (comboBox_nereye.Text == "BULGARİSTAN")
            {
                fiyat = 500;
            }
            if (comboBox_nereye.Text == "YUNANİSTAN")
            {
                fiyat = 500;
            }
            label11.Text = fiyat.ToString();
            //fiyatı guncelleme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set fiyat='" + fiyat + "' where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 kullanıcı = new Form4();
            kullanıcı.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox_tc.Text = oku["Tc_No"].ToString();
                textBox_isim.Text = oku["Ad"].ToString();
                textBox_soyisim.Text = oku["Soyad"].ToString();
            }
            baglantı.Close();
        }
    }
}
