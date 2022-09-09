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
    public partial class ParaTransferleri : Form
    {
        public ParaTransferleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ParaTransferiEft paraTransferiEft = new ParaTransferiEft();
            paraTransferiEft.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaTransferiHavale paraTransferiHavale = new ParaTransferiHavale();
            paraTransferiHavale.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KartliAnaSayfa kartliAnaSayfa = new KartliAnaSayfa();
            kartliAnaSayfa.Show();
            this.Hide();
        }
    }
}
