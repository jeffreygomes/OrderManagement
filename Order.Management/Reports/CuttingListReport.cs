using System;
using Order.Management.Utilities;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    class CuttingListReport : BaseReport
    {
        private static readonly int TABLE_WIDTH = 20;
        public CuttingListReport(Models.Order order) : base(order)
        {
        }

        public override void GenerateReport()
        {
            SetTableWidth(TABLE_WIDTH);
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(_order.ToString());
            GenerateCuttingListTable();
        }

        private void GenerateCuttingListTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();

            foreach (Shape shape in AvailableShapes)
            {
                PrintRow(shape, _order.GetQuantityByShape(shape));
            }
            PrintLine();
        }
    }
}
