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
    public partial class Kartsifregiris : Form
    {
        public Kartsifregiris()
        {
            InitializeComponent();
        }

        private void txt_giris2kartlı_Click(object sender, EventArgs e)
        {
            kullanıcı kul1 = new kullanıcı();

            
            if (txt_kartsifresi.Text == kul1.sifre)
            {
            
                MessageBox.Show("GİRİŞ BAŞARILI SAYFAYA YÖNLENDİRİLİYORSUNUZ...");
                KartliAnaSayfa KartAnaSayfa = new KartliAnaSayfa();
                KartAnaSayfa.Show();
                this.Hide();
            }       
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}