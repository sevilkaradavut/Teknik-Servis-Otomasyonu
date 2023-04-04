using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btnmkyt_Click(object sender, EventArgs e)
        {
            Musteri a = new Musteri();
            a.Show();
        }

        private void Btnkyt_Click(object sender, EventArgs e)
        {
            Personel b = new Personel();
            b.Show();
        }

        private void Btnarızakyt_Click(object sender, EventArgs e)
        {
            Arıza c = new Arıza();
            c.Show();
        }

        private void Btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
        }

        private void btnbitenis_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
        }

        private void btnyapılacakis_Click(object sender, EventArgs e)
        {
            Form7 k = new Form7();
            k.Show();
        }
    }
}
