using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikForm
{
    public partial class ParaYatırmaBolumu : Form
    {
        public ParaYatırmaBolumu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "200";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı kul1 = new kullanıcı();

            int yatırılacak_tutar = Convert.ToInt32(textBox1.Text);

            MessageBox.Show("Paranız Yatırılıyor...\nYeni Bakiyeniz : " + (kul1.bakiye + yatırılacak_tutar));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KartliAnaSayfa kartliAnaSayfa = new KartliAnaSayfa();
            kartliAnaSayfa.Show();
            this.Hide();
        }
    }
}
