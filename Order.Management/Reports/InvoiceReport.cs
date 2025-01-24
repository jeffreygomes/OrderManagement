using System;
using System.Collections.Generic;
using System.Text;
using Order.Management.Models;
using Order.Management.Utils;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    class InvoiceReport : Report
    {
        public InvoiceReport(Models.Order order) : base(order)
        {
        }

        public override void GenerateReport()
        {
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
            Console.WriteLine($"Red Color Surcharge       { redShapeQuantity} @ ${Constants.AdditionalCharge} ppi = ${redShapeQuantity * Constants.AdditionalCharge}");
        }
    }
}
