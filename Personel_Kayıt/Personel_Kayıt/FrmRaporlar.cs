using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Personel_Kayıt
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            try
            {
                // 1) SQL'den veriyi DataTable'a çek
                DataTable dt = new DataTable();

                string connStr =
                    @"Data Source=Barbaros;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql = "SELECT * FROM Tbl_Personel";   // tablo adın buysa
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }

                // 2) RDLC dosyasının yolunu ver
                string rdlcPath = Path.Combine(Application.StartupPath, "Report1.rdlc");
                if (!File.Exists(rdlcPath))
                {
                    MessageBox.Show("Report1.rdlc bulunamadı: " + rdlcPath);
                    return;
                }

                // 3) ReportViewer'a rapor ve veri setini bağla
                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rdlcPath;

                // Dikkat: "DataSet1" RDLC içindeki dataset adıyla aynı olmalı
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
