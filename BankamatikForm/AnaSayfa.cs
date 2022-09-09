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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

      
        

        private void txt_kartlı_text_Click(object sender, EventArgs e)
        {
          Kartsifregiris Kartliislem = new Kartsifregiris();
            Kartliislem.Show();
            Hide();


        }

        private void txt_kartsız_text_Click(object sender, EventArgs e)
        {
            Kartsizİslemler Kartsizislem = new Kartsizİslemler();
            Kartsizislem.Show();
            Hide();
        }

  
    }
}
