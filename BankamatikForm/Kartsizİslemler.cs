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
    public partial class Kartsizİslemler : Form
    {
        public Kartsizİslemler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaturaOdemeleriKartsız FaturaKartsiz = new FaturaOdemeleriKartsız();
            FaturaKartsiz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesabaParaKartsız HesabaParaKartsız = new HesabaParaKartsız();
            HesabaParaKartsız.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hgs hgs = new Hgs();
            hgs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
