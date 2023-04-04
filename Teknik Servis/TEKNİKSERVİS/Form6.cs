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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");



        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView9.DataSource = ds.Tables[0];
        }

        private void btnlisstee_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Bitenis");
        }

        private void btnbitiss_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * from Bitenis where Ad like '%" + tbbitenis.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView9.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
}
