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
    public partial class KartliAnaSayfa : Form
    {
        public KartliAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaCekmebolumu ParaCekbol = new ParaCekmebolumu();
            ParaCekbol.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaYatırmaBolumu ParaYatırBol = new ParaYatırmaBolumu();
            ParaYatırBol.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaTransferleri ParaTransfer = new ParaTransferleri();
            ParaTransfer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BilgiGuncelleme BilgiGuncelleme = new BilgiGuncelleme();
            BilgiGuncelleme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odemeler odemeler = new Odemeler();
            odemeler.Show();
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
