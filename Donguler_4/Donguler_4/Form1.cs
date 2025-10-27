using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // 1) önceki örnek 1 ile 10 arasındaki 3'e bölünebilen sayılar

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i%3==0)
            //        {
            //            listBox1.Items.Add(i);
            //        }
            //    }


            // 2) diğeri 1 ile 100 arasında 5 ve 7'ye tam bölünebilen sayılar

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 && i % 7 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //}

            // 3) Klavyeden girilen sayıların listesi

            //int sayi = Convert.ToInt16(textBox1.Text);

            //for (int i = 1; i <= sayi; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            // 4) Klavyeden giren sayıların tam bölümlerini veren bir program

            int sayi = Convert.ToInt16(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}
