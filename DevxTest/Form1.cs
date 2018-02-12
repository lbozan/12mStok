using System;
using System.Data;
using System.Diagnostics;

namespace DevxTest
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            txtBasTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtBitTarih.Text = DateTime.Now.AddDays(-20).ToString("dd.MM.yyyy");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Business _bns = new Business();

            DateTime baslangic = DateTime.Parse(txtBasTarih.Text);
            DateTime bitis = DateTime.Parse(txtBitTarih.Text);

            DataTable data = _bns.FilterDate(txtAra.Text, baslangic, bitis);

            gridControl1.DataSource = data;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                view.ExportToPdf("TestExport.pdf");
                Process pdfExport = new Process();
                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "TestExport.pdf";
                pdfExport.Start();
            }
        }
    }
}
