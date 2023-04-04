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
    public partial class Arıza : Form
    {
        public Arıza()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");
        public void ArızaA(string Arıza)
        {
            SqlDataAdapter da = new SqlDataAdapter(Arıza, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }



        private void btnarızagosterim_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnarızakayıt_Click(object sender, EventArgs e)
        {
            {
                SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");

                baglantı.Open();

                SqlCommand cmd = new SqlCommand("Insert Into Arıza(MusteriAdSoyad, UrunAdı,Durum, Marka,Model, AlısTarih,VerilisTarih ) values('" + tbarızamusteriad.Text + "','" + tburunad.Text + "','" + tbdurum.Text + "','" + tbmarka.Text + "','" + tbmodel.Text + "','" + tbalıstarih.Text + "','" + tbverilistarih.Text +  "') ", baglantı);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Gerçekleştirildi.");
                baglantı.Close();

                ArızaA("Select * from dbo.Arıza");
            }
          }

        private void btnarızalistele_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Arıza ");
        }

        private void btnarızatemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (baglantı.State == ConnectionState.Closed)
                {
                    baglantı.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglantı;
                    cmd.CommandText = "delete from dbo.Arıza where MusteriAdSoyad=@adsoyad ";
                    cmd.Parameters.AddWithValue("@adsoyad", dataGridView3.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silinmiştir");

                    listeleme();

                }
            }
        }
          
                private void Arıza_Load(object sender, EventArgs e)
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
                cmd.CommandText = "select *from dbo.Arıza";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "dbo.Arıza");
                dataGridView3.DataSource = ds.Tables["dbo.Arıza"];
                baglantı.Close();


            }

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView3.SelectedCells[0].RowIndex;
            string adsoyad = dataGridView3.Rows[secilialan].Cells[0].Value.ToString();
            string urunadı = dataGridView3.Rows[secilialan].Cells[1].Value.ToString();
            string durum = dataGridView3.Rows[secilialan].Cells[2].Value.ToString();
            string marka = dataGridView3.Rows[secilialan].Cells[3].Value.ToString();
            string model= dataGridView3.Rows[secilialan].Cells[4].Value.ToString();
            string alıstarih = dataGridView3.Rows[secilialan].Cells[5].Value.ToString();
            string veristarih = dataGridView3.Rows[secilialan].Cells[6].Value.ToString();

            tbarızamusteriad.Text = adsoyad;
            tburunad.Text = urunadı;
            tbdurum.Text = durum;
            tbmarka.Text = marka;
            tbmodel.Text = model;
            tbalıstarih.Text = alıstarih;
            tbverilistarih.Text = veristarih;
        }

        private void btnarızaguncelle_Click(object sender, EventArgs e)
        {
          
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("update Arıza set UrunAdı= '" + tburunad.Text + "', Durum ='" +tbdurum.Text + "', Marka= '" + tbmarka.Text + "', Model='" + tbmodel.Text + "', AlısTarih='" + tbalıstarih.Text + "',VerilisTarih = '" + tbverilistarih.Text + "' where MusteriAdSoyad= '" + tbarızamusteriad.Text + "'", baglantı);
            cmd.ExecuteNonQuery();
            verilerigoster("Select * from Arıza ");

            baglantı.Close();
        }
    }
    }

    


