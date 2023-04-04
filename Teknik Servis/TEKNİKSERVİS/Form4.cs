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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");


        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView6.DataSource = ds.Tables[0];
        }

        private void btnpersoneltumliste_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Personel ");
        }

        private void btnpersonelıptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpersonelgeri_Click(object sender, EventArgs e)
        {
            Personel fm3 = new Personel();
            this.Close();
            fm3.Show();
        }

        private void btnpersonelarama_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * from Personel where PersonelAd like '%" + tbpersoneladsoyad.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView6.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
    }

