using System;

namespace Order.Management.Reports
{
    class PaintingReport : Report
    {
        public PaintingReport(Models.Order order) : base(order)
        {
        }
        
        public override void GenerateReport()
        {
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(_order.ToString());
            GenerateTable();
        }
    }
}
