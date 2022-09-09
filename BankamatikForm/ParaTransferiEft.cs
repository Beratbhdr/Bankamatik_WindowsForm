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
    public partial class ParaTransferiEft : Form
    {
        public ParaTransferiEft()
        {
            InitializeComponent();
        }

        private void txt_transferet_Click(object sender, EventArgs e)
        {
            kullanıcı kul1 = new kullanıcı();
            int eft =Convert.ToInt32(txt_transferedilecekmiktar.Text);


            if (eft <= kul1.bakiye)
            {
                MessageBox.Show("EFT Onaylanıyor.Paranız Gönderiliyor...\n Yeni Bakiyeniz : " + (kul1.bakiye - eft));
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            KartliAnaSayfa kartliAnaSayfa = new KartliAnaSayfa();
            kartliAnaSayfa.Show();
            this.Hide();
        }
    }
}
