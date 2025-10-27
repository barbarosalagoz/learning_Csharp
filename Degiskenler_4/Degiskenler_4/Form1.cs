using System;
using System.Windows.Forms;

namespace Degiskenler_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 24;
            label1.Text = sayi.ToString();
        }
    }
}
