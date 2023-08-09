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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 admn = new Form6();
            admn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {//cevabı verıtabanına ekleme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update mesajlar set cevap='" + richTextBox1.Text + "' where ID=" + Convert.ToInt32(textBox1.Text) + "", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesaj Gönderildi");
            baglantı.Close();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from mesajlar ", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
