using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0;

            int[] sayi_listesi = { 4, 6, 7, 15, 16, 18, 34, 76, 96, 45 };

            foreach (int sl in sayi_listesi)
            {
                if (sl % 4 == 0)
                {
                    listBox1.Items.Add(sl.ToString());
                }

                label1.Text = sl.ToString();

                toplam = toplam + sl;
                label2.Text = toplam.ToString();
            }
        }
    }
}
