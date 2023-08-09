using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;

namespace Otobüsrojesi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        ArrayList liste = new ArrayList();
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        int sira1 = 0, sira2 = 0, sira3 = 0, sira4 = 0, sira5 = 0, sira6 = 0, sira7 = 0, sira8 = 0, sira9 = 0, sira10 = 0, sira11 = 0, sira12 = 0, sira13 = 0, sira14 = 0, sira15 = 0, sira16 = 0, sira17 = 0, sira18 = 0, sira19 = 0, sira20 = 0, sira21 = 0, sira22 = 0, sira23 = 0, sira24 = 0, sira25 = 0, sira26 = 0, sira27 = 0, sira28 = 0, sira29 = 0, sira30 = 0, sira31 = 0, sira32 = 0, sira33 = 0, sira34 = 0, sira35 = 0, sira36 = 0, sira37 = 0, sira38 = 0, sira39 = 0, sira40 = 0;

        private void button_sira35_Click(object sender, EventArgs e)
        {
            sira35++;
            enabled();
        }

        private void button_sira36_Click(object sender, EventArgs e)
        {
            sira36++;
            enabled();
        }

        private void button_sira37_Click(object sender, EventArgs e)
        {
            sira37++;
            enabled();
        }

        private void button_sira38_Click(object sender, EventArgs e)
        {
            sira38++;
            enabled();
        }

        private void button_sira39_Click(object sender, EventArgs e)
        {
            sira39++;
            enabled();
        }

        private void button_sira40_Click(object sender, EventArgs e)
        {
            sira40++;
            enabled();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void button_sira34_Click(object sender, EventArgs e)
        {
            sira34++;
            enabled();
        }

        private void button_sira33_Click(object sender, EventArgs e)
        {
            sira33++;
            enabled();
        }

        private void button_sira32_Click(object sender, EventArgs e)
        {
            sira32++;
            enabled();
        }

        private void button_sira31_Click(object sender, EventArgs e)
        {
            sira31++;
            enabled();
        }

        private void button_sira30_Click(object sender, EventArgs e)
        {
            sira30++;
            enabled();
        }

        private void button_sira29_Click(object sender, EventArgs e)
        {
            sira29++;
            enabled();
        }

        private void button_sira28_Click(object sender, EventArgs e)
        {
            sira28++;
            enabled();
        }

        private void button_sira27_Click(object sender, EventArgs e)
        {
            sira27++;
            enabled();
        }

        private void button_sira26_Click(object sender, EventArgs e)
        {
            sira26++;
            enabled();
        }

        private void button_sira25_Click(object sender, EventArgs e)
        {
            sira25++;
            enabled();
        }

        private void button_sira24_Click(object sender, EventArgs e)
        {
            sira24++;
            enabled();
        }

        private void button_sira23_Click(object sender, EventArgs e)
        {
            sira23++;
            enabled();
        }

        private void button_sira22_Click(object sender, EventArgs e)
        {
            sira22++;
            enabled();
        }

        private void button_sira21_Click(object sender, EventArgs e)
        {
            sira21++;
            enabled();
        }

        private void button_sira20_Click(object sender, EventArgs e)
        {
            sira20++;
            enabled();
        }

        private void button_sira19_Click(object sender, EventArgs e)
        {
            sira19++;
            enabled();
        }

        private void button_sira18_Click(object sender, EventArgs e)
        {
            sira18++;
            enabled();
        }

        private void button_sira17_Click(object sender, EventArgs e)
        {
            sira17++;
            enabled();
        }

        private void button_sira16_Click(object sender, EventArgs e)
        {
            sira16++;
            enabled();
        }

        private void button_sira15_Click(object sender, EventArgs e)
        {
            sira15++;
            enabled();
        }

        private void button_sira14_Click(object sender, EventArgs e)
        {
            sira14++;
            enabled();
        }

        private void button_sira13_Click(object sender, EventArgs e)
        {
            sira13++;
            enabled();
        }

        private void button_sira12_Click(object sender, EventArgs e)
        {
            sira12++;
            enabled();
        }

        private void button_sira11_Click(object sender, EventArgs e)
        {
            sira11++;
            enabled();
        }

        private void button_sira10_Click(object sender, EventArgs e)
        {
            sira10++;
            enabled();
        }

        private void button_sira9_Click(object sender, EventArgs e)
        {
            sira9++;
            enabled();
        }

        private void button_sira8_Click(object sender, EventArgs e)
        {
            sira8++;
            enabled();
        }

        private void button_sira7_Click(object sender, EventArgs e)
        {
            sira7++;
            enabled();
        }

        private void button_sira6_Click(object sender, EventArgs e)
        {
            sira6++;
            enabled();
        }

        private void button_sira5_Click(object sender, EventArgs e)
        {
            sira5++;
            enabled();
        }

        private void button_sira4_Click(object sender, EventArgs e)
        {
            sira4++;
            enabled();
        }

        private void button_sira3_Click(object sender, EventArgs e)
        {
            sira3++;
            enabled();
        }

        private void button_sira2_Click(object sender, EventArgs e)
        {
            sira2++;
            enabled();
        }

        private void button_sira1_Click(object sender, EventArgs e)
        {
            sira1++;
            enabled();
        }

        public void sifirla()
        {
            sira1 = 0;
            sira2 = 0;
            sira3 = 0;
            sira4 = 0;
            sira5 = 0;
            sira6 = 0;
            sira7 = 0;
            sira8 = 0;
            sira9 = 0;
            sira10 = 0;
            sira11 = 0;
            sira12 = 0;
            sira13 = 0;
            sira14 = 0;
            sira15 = 0;
            sira16 = 0;
            sira17 = 0;
            sira18 = 0;
            sira19 = 0;
            sira20 = 0;
            sira21 = 0;
            sira22 = 0;
            sira23 = 0;
            sira24 = 0;
            sira25 = 0;
            sira26 = 0;
            sira27 = 0;
            sira28 = 0;
            sira29 = 0;
            sira30 = 0;
            sira31 = 0;
            sira32 = 0;
            sira33 = 0;
            sira34 = 0;
            sira35 = 0;
            sira36 = 0;
            sira37 = 0;
            sira38 = 0;
            sira39 = 0;
            sira40 = 0;
        }
        public void enabled()
        {
            button_sira1.Enabled = false;
            button_sira2.Enabled = false;
            button_sira3.Enabled = false;
            button_sira4.Enabled = false;
            button_sira5.Enabled = false;
            button_sira6.Enabled = false;
            button_sira7.Enabled = false;
            button_sira8.Enabled = false;
            button_sira9.Enabled = false;
            button_sira10.Enabled = false;
            button_sira11.Enabled = false;
            button_sira12.Enabled = false;
            button_sira13.Enabled = false;
            button_sira14.Enabled = false;
            button_sira15.Enabled = false;
            button_sira16.Enabled = false;
            button_sira17.Enabled = false;
            button_sira18.Enabled = false;
            button_sira19.Enabled = false;
            button_sira20.Enabled = false;
            button_sira21.Enabled = false;
            button_sira22.Enabled = false;
            button_sira23.Enabled = false;
            button_sira24.Enabled = false;
            button_sira25.Enabled = false;
            button_sira26.Enabled = false;
            button_sira27.Enabled = false;
            button_sira28.Enabled = false;
            button_sira29.Enabled = false;
            button_sira30.Enabled = false;
            button_sira31.Enabled = false;
            button_sira32.Enabled = false;
            button_sira33.Enabled = false;
            button_sira34.Enabled = false;
            button_sira35.Enabled = false;
            button_sira36.Enabled = false;
            button_sira37.Enabled = false;
            button_sira38.Enabled = false;
            button_sira39.Enabled = false;
            button_sira40.Enabled = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frmkullanıcı = new Form4();
            frmkullanıcı.Show();
            this.Hide();
        }

        private void button_koltuksec_Click(object sender, EventArgs e)
        {
            if (sira1 == 1)
            {
                label_koltukno.Text = button_sira1.Text;
            }
            else if (sira2 == 1)
            {
                label_koltukno.Text = button_sira2.Text;
            }
            else if (sira3 == 1)
            {
                label_koltukno.Text = button_sira3.Text;
            }
            else if (sira4 == 1)
            {
                label_koltukno.Text = button_sira4.Text;
            }
            else if (sira5 == 1)
            {
                label_koltukno.Text = button_sira5.Text;
            }
            else if (sira6 == 1)
            {
                label_koltukno.Text = button_sira6.Text;
            }
            else if (sira7 == 1)
            {
                label_koltukno.Text = button_sira7.Text;
            }
            else if (sira8 == 1)
            {
                label_koltukno.Text = button_sira8.Text;
            }
            else if (sira9 == 1)
            {
                label_koltukno.Text = button_sira9.Text;
            }
            else if (sira10 == 1)
            {
                label_koltukno.Text = button_sira10.Text;
            }
            else if (sira11 == 1)
            {
                label_koltukno.Text = button_sira11.Text;
            }
            else if (sira12 == 1)
            {
                label_koltukno.Text = button_sira12.Text;
            }
            else if (sira13 == 1)
            {
                label_koltukno.Text = button_sira13.Text;
            }
            else if (sira14 == 1)
            {
                label_koltukno.Text = button_sira14.Text;
            }
            else if (sira15 == 1)
            {
                label_koltukno.Text = button_sira15.Text;
            }
            else if (sira16 == 1)
            {
                label_koltukno.Text = button_sira16.Text;
            }
            else if (sira17 == 1)
            {
                label_koltukno.Text = button_sira17.Text;
            }
            else if (sira18 == 1)
            {
                label_koltukno.Text = button_sira18.Text;
            }
            else if (sira19 == 1)
            {
                label_koltukno.Text = button_sira19.Text;
            }
            else if (sira20 == 1)
            {
                label_koltukno.Text = button_sira20.Text;
            }
            else if (sira21 == 1)
            {
                label_koltukno.Text = button_sira21.Text;
            }
            else if (sira22 == 1)
            {
                label_koltukno.Text = button_sira22.Text;
            }
            else if (sira23 == 1)
            {
                label_koltukno.Text = button_sira23.Text;
            }
            else if (sira24 == 1)
            {
                label_koltukno.Text = button_sira24.Text;
            }
            else if (sira25 == 1)
            {
                label_koltukno.Text = button_sira25.Text;
            }
            else if (sira26 == 1)
            {
                label_koltukno.Text = button_sira26.Text;
            }
            else if (sira27 == 1)
            {
                label_koltukno.Text = button_sira27.Text;
            }
            else if (sira28 == 1)
            {
                label_koltukno.Text = button_sira28.Text;
            }
            else if (sira29 == 1)
            {
                label_koltukno.Text = button_sira29.Text;
            }
            else if (sira30 == 1)
            {
                label_koltukno.Text = button_sira30.Text;
            }
            else if (sira31 == 1)
            {
                label_koltukno.Text = button_sira31.Text;
            }
            else if (sira32 == 1)
            {
                label_koltukno.Text = button_sira32.Text;
            }
            else if (sira33 == 1)
            {
                label_koltukno.Text = button_sira33.Text;
            }
            else if (sira34 == 1)
            {
                label_koltukno.Text = button_sira34.Text;
            }
            else if (sira35 == 1)
            {
                label_koltukno.Text = button_sira35.Text;
            }
            else if (sira36 == 1)
            {
                label_koltukno.Text = button_sira36.Text;
            }
            else if (sira37 == 1)
            {
                label_koltukno.Text = button_sira37.Text;
            }
            else if (sira38 == 1)
            {
                label_koltukno.Text = button_sira38.Text;
            }
            else if (sira39 == 1)
            {
                label_koltukno.Text = button_sira39.Text;
            }
            else if (sira40 == 1)
            {
                label_koltukno.Text = button_sira40.Text;
            }
            else
            {
                MessageBox.Show("SEÇİM YAPMADINIZ.");
            }
            //koltuk nosunu cerı tabanına ekleme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set KOLTUK_NO = '" + label_koltukno.Text.ToString() + "' WHERE ID=" + Convert.ToInt32(Form3.id) + "", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("SIRA EKLENDİ" + label_koltukno.Text);
            baglantı.Close();

            sifirla();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int koltuk;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select KOLTUK_NO from bilet_tablosu where NEREYE='" + Form7.nereye + "' and TARİH='" + Form7.tarih + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                koltuk = Convert.ToInt32(oku["KOLTUK_NO"]);

                if (koltuk == 1)
                {
                    button_sira1.Enabled = false;
                }
                if (koltuk == 2)
                {
                    button_sira2.Enabled = false;
                }
                if (koltuk == 3)
                {
                    button_sira3.Enabled = false;
                }
                if (koltuk == 4)
                {
                    button_sira4.Enabled = false;
                }
                if (koltuk == 5)
                {
                    button_sira5.Enabled = false;
                }
                if (koltuk == 6)
                {
                    button_sira6.Enabled = false;
                }
                if (koltuk == 7)
                {
                    button_sira7.Enabled = false;
                }
                if (koltuk == 8)
                {
                    button_sira8.Enabled = false;
                }
                if (koltuk == 9)
                {
                    button_sira9.Enabled = false;
                }
                if (koltuk == 10)
                {
                    button_sira10.Enabled = false;
                }
                if (koltuk == 11)
                {
                    button_sira11.Enabled = false;
                }
                if (koltuk == 12)
                {
                    button_sira12.Enabled = false;
                }
                if (koltuk == 13)
                {
                    button_sira13.Enabled = false;
                }
                if (koltuk == 14)
                {
                    button_sira14.Enabled = false;
                }
                if (koltuk == 15)
                {
                    button_sira15.Enabled = false;
                }
                if (koltuk == 16)
                {
                    button_sira16.Enabled = false;
                }
                if (koltuk == 17)
                {
                    button_sira17.Enabled = false;
                }
                if (koltuk == 18)
                {
                    button_sira18.Enabled = false;
                }
                if (koltuk == 19)
                {
                    button_sira19.Enabled = false;
                }
                if (koltuk == 20)
                {
                    button_sira20.Enabled = false;
                }
                if (koltuk == 21)
                {
                    button_sira21.Enabled = false;
                }
                if (koltuk == 22)
                {
                    button_sira22.Enabled = false;
                }
                if (koltuk == 23)
                {
                    button_sira23.Enabled = false;
                }
                if (koltuk == 24)
                {
                    button_sira24.Enabled = false;
                }
                if (koltuk == 25)
                {
                    button_sira25.Enabled = false;
                }
                if (koltuk == 26)
                {
                    button_sira26.Enabled = false;
                }
                if (koltuk == 27)
                {
                    button_sira27.Enabled = false;
                }
                if (koltuk == 28)
                {
                    button_sira28.Enabled = false;
                }
                if (koltuk == 29)
                {
                    button_sira29.Enabled = false;
                }
                if (koltuk == 30)
                {
                    button_sira30.Enabled = false;
                }
                if (koltuk == 31)
                {
                    button_sira31.Enabled = false;
                }
                if (koltuk == 32)
                {
                    button_sira32.Enabled = false;
                }
                if (koltuk == 33)
                {
                    button_sira33.Enabled = false;
                }
                if (koltuk == 34)
                {
                    button_sira34.Enabled = false;
                }
                if (koltuk == 35)
                {
                    button_sira35.Enabled = false;
                }
                if (koltuk == 36)
                {
                    button_sira36.Enabled = false;
                }
                if (koltuk == 37)
                {
                    button_sira37.Enabled = false;
                }
                if (koltuk == 38)
                {
                    button_sira38.Enabled = false;
                }
                if (koltuk == 39)
                {
                    button_sira39.Enabled = false;
                }
                if (koltuk == 40)
                {
                    button_sira40.Enabled = false;
                }
            }
            baglantı.Close();
        }
    }
}
