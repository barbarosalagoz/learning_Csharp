using System;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        // Sayaçlar
        private int soruno = 0, dogru = 0, yanlis = 0;

        // Cevaplar (UI’dan bağımsız; görünmez)
        private string dogruCevap = string.Empty;
        private string secilenCevap = string.Empty;

        // Toplam soru sayısı (istersen arttır)
        private const int ToplamSoru = 3;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıç görünümü
            BtnA.Enabled = BtnB.Enabled = BtnC.Enabled = BtnD.Enabled = false;
            BtnSonraki.Enabled = true;    // İlk soruyu bununla başlatacağız
            pictureBox1.Visible = false;  // ✓
            pictureBox2.Visible = false;  // ✗

            LblSoruNo.Text = "0";
            LblDogru.Text = "0";
            LblYanlis.Text = "0";
            richTextBox1.Clear();
        }

        // --- Ortak yardımcılar ---

        private void YükleSoru(int no)
        {
            // Yeni soru için sahneyi hazırla
            BtnA.Enabled = BtnB.Enabled = BtnC.Enabled = BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            secilenCevap = string.Empty;

            LblSoruNo.Text = no.ToString();

            switch (no)
            {
                case 1:
                    richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                    BtnA.Text = "1920";
                    BtnB.Text = "1921";
                    BtnC.Text = "1922";
                    BtnD.Text = "1923";
                    dogruCevap = "1923";
                    break;

                case 2:
                    richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                    BtnA.Text = "İzmir";
                    BtnB.Text = "Balıkesir";
                    BtnC.Text = "Aydın";
                    BtnD.Text = "Manisa";
                    dogruCevap = "Balıkesir";
                    break;

                case 3:
                    richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                    BtnA.Text = "Sait Faik Abasıyanık";
                    BtnB.Text = "Cemal Süreyya";
                    BtnC.Text = "Attila İlhan";
                    BtnD.Text = "Reşat Nuri Güntekin";
                    dogruCevap = "Sait Faik Abasıyanık";
                    break;

                default:
                    // Bitti
                    BtnA.Enabled = BtnB.Enabled = BtnC.Enabled = BtnD.Enabled = false;
                    BtnSonraki.Enabled = false;
                    richTextBox1.Text = "Tebrikler Mr. Stark, yarışma bitti!";
                    return;
            }
        }

        private void CevapVer(Button secilenButon)
        {
            // Cevap seçildi
            BtnA.Enabled = BtnB.Enabled = BtnC.Enabled = BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            secilenCevap = secilenButon.Text;

            if (secilenCevap == dogruCevap)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; // ✓
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;  // ✗
            }
        }

        // --- Event’ler ---

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            if (soruno <= ToplamSoru)
                YükleSoru(soruno);
            else
            {
                // Emniyet: Toplam soruyu aştıysa kilitle
                BtnA.Enabled = BtnB.Enabled = BtnC.Enabled = BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                richTextBox1.Text = "Tüm sorular tamamlandı.";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }

        private void BtnA_Click(object sender, EventArgs e) => CevapVer(BtnA);
        private void BtnB_Click(object sender, EventArgs e) => CevapVer(BtnB);
        private void BtnC_Click(object sender, EventArgs e) => CevapVer(BtnC);
        private void BtnD_Click(object sender, EventArgs e) => CevapVer(BtnD);
    }
}
