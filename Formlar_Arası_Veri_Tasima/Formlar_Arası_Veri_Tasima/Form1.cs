using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Tasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.mesaj = textBox1.Text;
            //frm.Show();
            //this.Hide();


            Form2 fr = new Form2();
            fr.m1 = textBox1.Text;
            fr.m2 = textBox2.Text;
            fr.m3 = textBox3.Text;
            fr.Show();
            this.Hide();
        }
    }
}
