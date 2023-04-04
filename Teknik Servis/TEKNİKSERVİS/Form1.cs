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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2R29TO8\\SQLEXPRESS;Initial Catalog=ürüntakip;Integrated Security=True");

        private void btngrs_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                string sql = "Select * From üyeler where Kullanıcı_Adı  = @kullanıcı AND Şifre = @sifre ";
                SqlParameter prm1 = new SqlParameter("kullanıcı", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Menu frm1 = new Menu();
                    frm1.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATALI GİRİŞ");
            }

        }
    }

}
