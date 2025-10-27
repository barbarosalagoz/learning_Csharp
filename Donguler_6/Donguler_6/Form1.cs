using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // do while = while + 1 oluyor yapmak istemese de yapıyor

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listbox1.Items.Add("Merhaba Gaziantep!");
                i++;
            }
            while(i <= 10)
        }
    }
}
