using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Tasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public string mesaj;

        public string m1, m2, m3;

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = mesaj;
            listBox1.Items.Add(m3);
            listBox1.Items.Add(m2);
            listBox1.Items.Add(m1);
        }
    }
}
