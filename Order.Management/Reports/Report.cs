using Microsoft.VisualBasic;
using Order.Management.Models;
using Order.Management.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using static Order.Management.Models.Constants;

namespace Order.Management.Reports
{
    public abstract class Report
    {
        private int TableWidth = 73;

        protected readonly Models.Order _order;
        protected Report(Models.Order order) 
        { 
            _order = order;
        }
        public abstract void GenerateReport();

        protected void SetTableWidth(int width)
        {
            TableWidth = width;
        }

        public void GenerateTable()
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

        public void PrintLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public void PrintRow(params object[] columns)
        {
            int width = (TableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
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
