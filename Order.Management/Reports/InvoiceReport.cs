using Order.Management.Models;
using Order.Management.Utilities;
using System;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    class InvoiceReport : BaseReport
    {
        private static readonly int TABLE_WIDTH = 73;
        public InvoiceReport(Models.Order order) : base(order)
        {
        }

        public override void GenerateReport()
        {
            SetTableWidth(TABLE_WIDTH);
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(_order.ToString());
            GenerateTable();
            GenerateOrderDetails();
        }

        private void GenerateOrderDetails()
        {
            // Calculate and display price by shapes
            var invoiceTotal = 0M;
            foreach (Shape shape in AvailableShapes)
            {
                var shapeQuantity = _order.GetQuantityByShape(shape);
                var shapeUnitPrice = GetShapePrice(shape);
                var costByBlock = shapeQuantity * shapeUnitPrice;
                invoiceTotal += costByBlock;
                Console.WriteLine($"{shape}s 		  {shapeQuantity} @ ${shapeUnitPrice} ppi = ${costByBlock}");
            }

            // Calculate and display red paint surcharge
            var redShapeQuantity = _order.GetQuantityByColor(Color.Red);
            var redPaintSurcharge = redShapeQuantity * Constants.RedPaintAdditionalCharge;
            invoiceTotal += redPaintSurcharge;
            Console.WriteLine($"Red Color Surcharge       {redShapeQuantity} @ ${Constants.RedPaintAdditionalCharge} ppi = ${redPaintSurcharge}");

            Console.WriteLine($"\nTotal: ${invoiceTotal}");
        }
    }
}
