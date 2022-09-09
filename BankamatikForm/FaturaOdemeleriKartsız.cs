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
    public partial class FaturaOdemeleriKartsız : Form
    {
        public FaturaOdemeleriKartsız()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kartsizİslemler kartsizİslemler = new Kartsizİslemler();
            kartsizİslemler.Show();
            this.Hide();
        }
    }
}
