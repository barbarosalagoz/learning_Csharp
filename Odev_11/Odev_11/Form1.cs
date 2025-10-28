using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Doldur()
        {
            TxtIsim.Text = "Barbaros Emre";
            TxtSoyisim.Text = "Alagöz";
            TxtYas.Text = "36";
            TxtMeslek.Text = "Yazılım Uzmanı";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
