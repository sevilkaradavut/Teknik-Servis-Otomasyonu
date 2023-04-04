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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");
        public void Musterii(string Musteri)
        {
            SqlDataAdapter da = new SqlDataAdapter(Musteri, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btngosterim_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.Show();
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            {
                SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");

                baglantı.Open();

                SqlCommand cmd = new SqlCommand("Insert Into Musteri(MusteriNo, MusteriAd, MusteriSoyad, MusteriTc, MusteriTel, PersonelNo,isNo,ArParcaNo, MusteriAdres ) values('" + tbmusterino.Text + "','" + tbmusteriad.Text + "','" + tbmusterisoyad.Text + "','" + tbmusteritc.Text + "','" + tbmusteritel.Text + "','" + tbpersonelno.Text + "','" + tbisno.Text + "','" + tbarparcano.Text + "', '" + tbmusteriadres.Text + "') ", baglantı);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Gerçekleştirildi.");
                baglantı.Close();

                Musterii("Select * from dbo.Musteri");
            }

        }

        private void btnlistele_Click(object sender, EventArgs e)
        
            {
                verilerigoster("Select * from Musteri ");
            }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (baglantı.State == ConnectionState.Closed)
                {
                    baglantı.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglantı;
                    cmd.CommandText = "delete from dbo.Musteri where MusteriNo=@numara ";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silinmiştir");

                    listeleme();

                }
            }

        }

        private void Musteri_Load(object sender, EventArgs e)
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
                cmd.CommandText = "select *from dbo.Musteri";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "dbo.Musteri");
                dataGridView1.DataSource = ds.Tables["dbo.Musteri"];
                baglantı.Close();


            }
        }
             private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string MusteriNo = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string MusteriAdı = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string MusteriSoyadı = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string MusteriTc = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string MusteriTel = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string PersonelNo = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            string isNo = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            string ArParcaNo = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            string MusteriAdres = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();


            tbmusterino.Text = MusteriNo;
            tbmusteriad.Text = MusteriAdı;
            tbmusterisoyad.Text = MusteriSoyadı;
            tbmusteritc.Text = MusteriTc;
            tbmusteritel.Text = MusteriTel;
            tbpersonelno.Text = PersonelNo;
            tbisno.Text = isNo;
            tbarparcano.Text = ArParcaNo;
            tbmusteriadres.Text = MusteriAdres;


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("update Musteri set MusteriNo= '" + tbmusterino.Text + "', MusteriSoyad ='" + tbmusterisoyad.Text + "', MusteriTc= '" + tbmusteritc.Text + "', MusteriTel='" + tbmusteritel.Text + "',PersonelNo= '" + tbpersonelno.Text + "',isNo= '" + tbisno.Text + "',ArParcaNo = '" + tbarparcano.Text + "', MusteriAdres= '" + tbmusteriadres.Text + "' where MusteriAd = '" + tbmusteriad.Text + "'", baglantı);
            cmd.ExecuteNonQuery();
            verilerigoster("Select * from Musteri ");
        
        baglantı.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string no = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string tc = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string tel = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string personelno = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string isno = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string arparcano = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string adres = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();

            tbmusterino.Text = no;
            tbmusteriad.Text = ad;
            tbmusterisoyad.Text = soyad;
            tbmusteritc.Text = tc;
            tbmusteritel.Text = tel;
            tbpersonelno.Text = personelno;
            tbisno.Text = isno;
            tbarparcano.Text = arparcano;
            tbmusteriadres.Text = adres;

           
        }
    }
    }

    
    

