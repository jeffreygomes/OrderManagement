using System;

namespace Order.Management.Reports
{
    class PaintingReport : BaseReport
    {
        private static readonly int TABLE_WIDTH = 73;
        public PaintingReport(Models.Order order) : base(order)
        {
        }
        
        public override void GenerateReport()
        {
            SetTableWidth(TABLE_WIDTH);
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(_order.ToString());
            GenerateTable();
        }
    }
}
