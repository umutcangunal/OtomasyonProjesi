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
using System.Text.RegularExpressions; //şifre güvenliğini sağlamak için
using System.IO; // tckimlik numaramızla kaydetmek için

namespace Otobüsrojesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        int zaman = 30;
        int parolaskor = 0;
        private void button_kayıt_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (textBox_ad.Text == "" || textBox_soyad.Text == "" || textBox_tc.Text == "" || textBox_kadi.Text == "" || textBox_sifre.Text == "" || textBox_sifretekrar.Text == "")
            {
                MessageBox.Show("Boş geçemezsiniz!");
            }
            else if (textBox_sifretekrar.Text == "" || textBox_sifre.Text != textBox_sifretekrar.Text)
            {
                MessageBox.Show("şifreler aynı değil!");
            }
            else if (textBox_tc.TextLength > 11 || textBox_tc.Text == "")
            {
                MessageBox.Show("tc 11 karakter olmalı!");
            }
            else
            {
                // bilet tablosuna ad,soyad,kadi,sifre,tcno ekleme
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into bilet_tablosu(Ad,Soyad,K_adi,Sifre,Tc_No) values('" + textBox_ad.Text + "','" + textBox_soyad.Text + "','" + textBox_kadi.Text + "','" + textBox_sifre.Text + "','" + textBox_tc.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi!");
                baglanti.Close();
                Form1 anasayf = new Form1();
                anasayf.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = zaman.ToString();
            zaman = zaman - 1;
            if (zaman == 0)
            {
                Form1 anasayf = new Form1();
                anasayf.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void textBox_sifre_TextChanged(object sender, EventArgs e)
        {
            int kharf = 0, bharf = 0, rakam = 0, sembol = 0;
            string sifre = label5.Text;
            string dsifre = sifre;
            dsifre.Replace('İ', 'I');
            dsifre.Replace('Ğ', 'G');
            dsifre.Replace('Ü', 'U');
            dsifre.Replace('Ş', 'S');
            dsifre.Replace('Ç', 'C');
            dsifre.Replace('Ö', 'O');
            dsifre.Replace('ı', 'i');
            dsifre.Replace('ğ', 'g');
            dsifre.Replace('ü', 'u');
            dsifre.Replace('ş', 's');
            dsifre.Replace('ç', 'c');
            dsifre.Replace('ö', 'o');

            if (sifre != dsifre)
            {
                sifre = dsifre;
                textBox_sifre.Text = sifre;
                //İĞÜŞÇÖ ığüşçö
                MessageBox.Show("parolanızdaki türkçe karakterler dönüştürülmüştür");

            }
            //1 küçük 10 puan, 1 den fazla kullanılmış ise 20 puan
            int kharfsayi = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length;
            kharf = Math.Min(2, kharfsayi) * 10;

            int bharfsayi = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            bharf = Math.Min(2, bharfsayi) * 10;

            int rakamsayi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            rakam = Math.Min(2, rakam) * 10;

            int sembolsayi = sifre.Length - rakamsayi - bharfsayi - kharfsayi;
            sembol = Math.Min(2, sembolsayi) * 10;

            parolaskor = kharf + bharf + rakam + sembol;

            if (sifre.Length > 8)
            {
                parolaskor = parolaskor + 20;
            }
            if (kharf == 0 || bharf == 0 || rakam == 0 || sembol == 0)
            {
                label10.Text = "rakam,sembıl,küçük ve büyük harf kullanınız";
            }
            if (kharf != 0 || bharf != 0 || rakam != 0 || sembol != 0)
            {
                label10.Text = "";
            }
            if (parolaskor < 70)
            {
                label10.Text = "düşük";
            }
            else
            {
                label10.Text = "yüksek";
            }
            label11.Text = Convert.ToString(parolaskor);
            progressBar1.Value = parolaskor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_sifre.PasswordChar.ToString() == "*")
            {
                textBox_sifre.PasswordChar = char.Parse("\0");
                button2.Text = "Gizle";
            }
            else
            {
                textBox_sifre.PasswordChar = char.Parse("*");
                button2.Text = "Göster";
            }

            if (textBox_sifretekrar.PasswordChar.ToString() == "*")
            {
                textBox_sifretekrar.PasswordChar = char.Parse("\0");
                button2.Text = "Gizle";
            }
            else
            {
                textBox_sifretekrar.PasswordChar = char.Parse("*");
                button2.Text = "Göster";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_ad.Clear();
            textBox_soyad.Clear();
            textBox_tc.Clear();
            textBox_kadi.Clear();
            textBox_sifre.Clear();
            textBox_sifretekrar.Clear();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
