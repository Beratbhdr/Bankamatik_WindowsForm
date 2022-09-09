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
    public partial class Hgs : Form
    {
        public Hgs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı kul1 =new kullanıcı();
           if( kul1.plaka == txt_plaka.Text)
           {
                MessageBox.Show("HGS BORCUNUZ BULUNAMAMAKTADIR.");
           }
           else
           {
                MessageBox.Show("PLAKA KAYDI YOK..");
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
