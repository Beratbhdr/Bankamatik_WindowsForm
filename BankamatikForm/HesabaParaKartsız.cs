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
    public partial class HesabaParaKartsız : Form
    {
        public HesabaParaKartsız()
        {
            InitializeComponent();
        }

        private void txt_parayatırkartsız_Click(object sender, EventArgs e)
        {
            kullanıcı kul1 = new kullanıcı();
            int eft = Convert.ToInt32(txt_yatırılıcaktutar.Text);


            if (eft <= kul1.bakiye)
            {
                MessageBox.Show("Paranız Yatırılıyor...\n Yeni Bakiyeniz : " + (kul1.bakiye - eft));
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kartsizİslemler kartsizİslemler = new Kartsizİslemler();
            kartsizİslemler.Show();
            this.Hide();
        }
    }
}
