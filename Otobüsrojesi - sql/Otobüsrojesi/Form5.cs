using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüsrojesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_kad.Text == "admin" && textBox_sifre.Text == "123")
            {
                MessageBox.Show("Hoşgeldin" + textBox_kad.Text);
                Form6 admnblg = new Form6();
                admnblg.Show();
                this.Hide();
            }
            else if (textBox_kad.Text == "" && textBox_sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Girilmedi");
            }
            else if (textBox_kad.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı  Girilmedi");
            }
            else if (textBox_sifre.Text == "")
            {
                MessageBox.Show("Şifre Girilmedi");
            }
            else if (textBox_kad.Text != "admin" && textBox_sifre.Text != "123")
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
            }
            else if (textBox_kad.Text != "admin")
            {
                MessageBox.Show("Kullanıcı Adı  Yanlış");
            }
            else if (textBox_sifre.Text != "123")
            {
                MessageBox.Show("Şifre Yanlış");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_kad.Clear();
            textBox_sifre.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_sifre.PasswordChar.ToString() == "*")
            {
                textBox_sifre.PasswordChar = char.Parse("\0");
                button3.Text = "Gizle";
            }
            else
            {
                textBox_sifre.PasswordChar = char.Parse("*");
                button3.Text = "Göster";
            }
        }
    }
}
