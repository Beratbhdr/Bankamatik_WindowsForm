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
    public partial class BilgiGuncelleme : Form
    {
        public BilgiGuncelleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz Güncellendi.");
            


        }

        private void txt_eskisifre_TextChanged(object sender, EventArgs e)
        {
            kullanıcı kul1 = new kullanıcı();
            kul1.sifre = txt_eskisifre.Text;

        }

        private void txt_yenisifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KartliAnaSayfa kartliAnaSayfa = new KartliAnaSayfa();
            kartliAnaSayfa.Show();
            this.Hide();
        }
    }
}
