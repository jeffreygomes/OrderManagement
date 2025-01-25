using Order.Management.Utilities;
using System;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    public abstract class BaseReport
    {
        protected readonly Models.Order _order;
        protected int _tableWidth;
        protected BaseReport(Models.Order order) 
        { 
            _order = order;
        }
        public abstract void GenerateReport();

        protected void SetTableWidth(int width)
        {
            _tableWidth = width;
        }

        protected void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            
            foreach(Shape shape in AvailableShapes)
            {
                PrintRow(
                    shape,
                    _order.GetQuantityByShapeAndColour(shape, Colour.Red),
                    _order.GetQuantityByShapeAndColour(shape, Colour.Blue),
                    _order.GetQuantityByShapeAndColour(shape, Colour.Yellow)
                );
            }
            PrintLine();
        }

        protected void PrintLine()
        {
            Console.WriteLine(new string('-', _tableWidth));
        }

        protected void PrintRow(params object[] columns)
        {
            int width = (_tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (object column in columns)
            {
                row += AlignCentre(column.ToString(), width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }       
    }
}
