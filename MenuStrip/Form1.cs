using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Barbaros Alagöz tarafından yapıldı", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async(null);

            webView21.Source = new Uri("https://www.youtube.com/watch?v=hEJnMQG9ev8");

            label1.Text = "Mad Max";
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async(null);

            webView21.Source = new Uri("https://www.youtube.com/watch?v=CZzW6_hR068");

            label1.Text = "P.S. I Love You";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async(null);

            webView21.Source = new Uri("https://www.youtube.com/watch?v=aQnlngjZG48");
            label1.Text = "Aynı Yıldızın Altında";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async(null);

            webView21.Source = new Uri("https://www.youtube.com/watch?v=bMgfsdYoEEo");
            label1.Text = "The Conjuring";
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async(null);

            webView21.Source = new Uri("https://www.youtube.com/watch?v=7BWWWQzTpNU");
            label1.Text = "Passengers";
        }
    }
}
