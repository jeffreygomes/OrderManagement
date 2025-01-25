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
            // TODO: Consider generating totals of entire order
            SetTableWidth(TABLE_WIDTH);
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(_order.ToString());
            GenerateTable();
            GenerateOrderDetailsByShape();
            GenerateRedPaintSurcharge();
        }

        public void GenerateOrderDetailsByShape()
        {
            foreach (Shape shape in AvailableShapes)
            {
                var shapeQuantity = _order.GetQuantityByShape(shape);
                var shapePrice = GetShapePrice(shape);
                Console.WriteLine(                    $"{shape}s 		  {shapeQuantity} @ ${shapePrice} ppi = ${shapeQuantity * shapePrice}");
            }
        }

        public void GenerateRedPaintSurcharge()
        {
            var redShapeQuantity = _order.GetQuantityByColour(Colour.Red);
            Console.WriteLine($"Red Colour Surcharge      { redShapeQuantity} @ ${Constants.AdditionalCharge} ppi = ${redShapeQuantity * Constants.AdditionalCharge}");
        }
    }
}
