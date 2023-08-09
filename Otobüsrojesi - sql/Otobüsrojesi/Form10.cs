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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-S6OMDCV;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 kullanıcı = new Form4();
            kullanıcı.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // id ileti cevap kullanıcıidye gore datagırdvıewde gosterıldı
            SqlDataAdapter da = new SqlDataAdapter("select ID,ileti,cevap from mesajlar where kullaniciid=" + Convert.ToInt32(Form3.id) + "", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
