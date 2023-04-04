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

namespace TEKNİKSERVİS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");


        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void btnarızaliste_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Arıza ");
        }

        private void btnarızaıptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnarızageri_Click(object sender, EventArgs e)
        {
            Arıza fm2 = new Arıza();
            this.Close();
            fm2.Show();
        }

        private void btnarızaarama_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * from Arıza where MusteriAdSoyad like '%" + tbarızaadsoyad.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
}
