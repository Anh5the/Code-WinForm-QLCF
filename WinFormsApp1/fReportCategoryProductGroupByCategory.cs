using Microsoft.Reporting.WinForms;
using System.Data;

namespace QLBH
{
    public partial class fReportCategoryProductGroupByCategory : Form
    {
        EFDbContext db = new EFDbContext();
        public fReportCategoryProductGroupByCategory()
        {
            InitializeComponent();
        }

        private void fReportCategoryProductGroupByCategory_Load(object sender, EventArgs e)
        {


            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("ds_View_CategoryProduct", db.Products.Select(p => new
           {
               p.ProductID,
               p.Name,
               p.Quantity,
               p.Price,
               p.MarketPrice,
               p.Description,
               p.ImageFile,
               p.Status,
               p.Category.CategoryName,
               p.Category.Order,
               p.Category.CategoryStatus
           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rCategoryProductGroupByCategory.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }

    }
}
