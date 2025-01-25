using Order.Management.Reports;

namespace Order.Management.Utilities
{
    internal class ReportHelper
    {
        // Generate Painting Report 
        public static void GeneratePaintingReport(Models.Order order)
        {
            PaintingReport paintingReport = new PaintingReport(order);
            paintingReport.GenerateReport();
        }

        // Generate Cutting List Report 
        public static void GenerateCuttingListReport(Models.Order order)
        {
            CuttingListReport cuttingListReport = new CuttingListReport(order);
            cuttingListReport.GenerateReport();
        }

        // Generate Invoice Report 
        public static void GenerateInvoiceReport(Models.Order order)
        {
            InvoiceReport invoiceReport = new InvoiceReport(order);
            invoiceReport.GenerateReport();
        }
    }
}
