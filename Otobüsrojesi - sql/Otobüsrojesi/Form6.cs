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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int id;
        static public int sira;
        static public string tarih, nereye;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");

        public void verilerigoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from bilet_tablosu ", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox_sil.Text == "")
            {
                MessageBox.Show("LÜTFEN SİLMEK İSTEDİĞİNİZ İD SİNİ GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult secenek;
                secenek = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("delete from bilet_tablosu where ID =" + textBox_sil.Text + "", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("kayıt Silindi");
                    verilerigoster();
                    temizle();

                }
            }
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where ID like'" + textBox_ara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            temizle();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            label_sil.Visible = true;
            textBox_sil.Visible = true;
            button2.Visible = true;
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            label_ara.Visible = true;
            textBox_ara.Visible = true;
            button3.Visible = true;
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set Tc_No='" + textBox_tc.Text + "',Ad='" + textBox_isim.Text + "',Soyad='" + textBox_soyisim.Text + "',YAŞ='" + comboBox_yas.Text.ToString() + "',TELEFON='" + textBox_tel.Text + "',CİNSİYET='" + comboBox_cinsiyet.Text.ToString() + "',NEREDEN='" + comboBox_nereden.Text.ToString() + "',NEREYE='" + comboBox_nereye.Text.ToString() + "',SAAT='" + comboBox_saat.Text.ToString() + "',ADET='" + comboBox_adet.Text.ToString() + "',TARİH='" + dateTimePicker_tarih.Text.ToString() + "' where ID=" + Convert.ToInt32(label_id.Text) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KAYIT GUNCELLENDİ");
            verilerigoster();
            temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_tc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_yas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_tel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox_cinsiyet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox_nereden.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox_nereye.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox_saat.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            comboBox_adet.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ansyf = new Form1();
            ansyf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 glnmsj = new Form11();
            glnmsj.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            verilerigoster();
            label_sil.Visible = false;
            button2.Visible = false;
            textBox_sil.Visible = false;
            label_ara.Visible = false;
            textBox_ara.Visible = false;
            button3.Visible = false;
            label_id.Visible = false;
        }
    }
}
