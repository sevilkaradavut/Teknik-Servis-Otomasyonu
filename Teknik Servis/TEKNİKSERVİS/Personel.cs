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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");
        public void Personell(string Personel)
        {
            SqlDataAdapter da = new SqlDataAdapter(Personel, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }




        private void btnpersonelgosterim_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
        }

        private void btnpersonelkayıt_Click(object sender, EventArgs e)
        {
            {
                SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");

                baglantı.Open();

                SqlCommand cmd = new SqlCommand("Insert Into Personel(PersonelNo, PersonelAd,PersonelSoyad, PersonelDahili, Maas_No ) values('" + tbpersonell.Text + "','" + tbpersonelad.Text + "','" + tbpersonelsoyad.Text + "','" + tbpersoneldahili.Text + "','" + tbmaasno.Text + "') ", baglantı);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Gerçekleştirildi.");
                baglantı.Close();

                Personell("Select * from dbo.Personel");
            }

        }

        private void btnpersonellistele_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Personel");
        }

        private void btnpersonelsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (baglantı.State == ConnectionState.Closed)
                {
                    baglantı.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglantı;
                    cmd.CommandText = "delete from dbo.Personel where PersonelNo=@no";
                    cmd.Parameters.AddWithValue("@no", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silinmiştir");

                    listeleme();
                }
            }
        }
        private void Personel_Load(object sender, EventArgs e)
        {
            listeleme();
        }
        void listeleme()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "select *from dbo.Personel";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "dbo.,Personel");
                dataGridView2.DataSource = ds.Tables["dbo.Personel"];
                baglantı.Close();


            }
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView2.SelectedCells[0].RowIndex;
            string no = dataGridView2.Rows[secilialan].Cells[0].Value.ToString();
            string ad = dataGridView2.Rows[secilialan].Cells[1].Value.ToString();
            string soyad = dataGridView2.Rows[secilialan].Cells[2].Value.ToString();
            string dahili= dataGridView2.Rows[secilialan].Cells[3].Value.ToString();
            string maasno = dataGridView2.Rows[secilialan].Cells[4].Value.ToString();

            tbpersonell.Text = no;
            tbpersonelad.Text = ad;
            tbpersonelsoyad.Text = soyad;
            tbpersoneldahili.Text = dahili;
            tbmaasno.Text = maasno;
            

        }

        private void btnpersonelguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("update Personel set PersonelNo= '" + tbpersonell.Text + "', PersonelSoyad ='" + tbpersonelsoyad.Text + "', PersonelDahili= '" + tbpersoneldahili.Text + "', Maas_No='" + tbmaasno.Text + "' where PersonelAd = '" +tbpersonelad.Text + "'", baglantı);
            cmd.ExecuteNonQuery();
            verilerigoster("Select * from Personel ");

            baglantı.Close();

        }
    }
}

