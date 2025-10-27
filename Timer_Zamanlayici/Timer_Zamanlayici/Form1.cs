using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Zamanlayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // global alan
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sayac++;
            //label1.Text = sayac.ToString();
            //if (sayac == 50)
            //{
            //    timer1.Stop();
            //    this.BackColor = Color.PeachPuff;
            //}
            // loop'a girer değişken aralığında çıkar (int)

            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 10)
            {
                this.BackColor = Color.PeachPuff;
            }

            if (sayac == 20)
            {
                this.BackColor = Color.Green;
            }

            if (sayac == 30)
            {
                sayac = 0;
                timer1.Stop();
            }
        }
    }
}
