using System;
using Order.Management.Utils;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    class CuttingListReport : Report
    {
        public int TableWidth = 20;
        public CuttingListReport(Models.Order order) : base(order)
        {
        }

        public override void GenerateReport()
        {
            SetTableWidth(TableWidth);
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
