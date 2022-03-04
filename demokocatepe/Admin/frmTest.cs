using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demokocatepe.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi=Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bakteri=1, sayi,i;

            for (i = 1; i <= 24; i++)
            {
                sayi = bakteri * 2;
            }

        }
    }
}
