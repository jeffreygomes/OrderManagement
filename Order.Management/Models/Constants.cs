using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Management.Models
{
    public static class Constants
    {
        public const decimal SquarePrice = 1;
        public const decimal TrianglePrice = 2;
        public const decimal CirclePrice = 3;

        public const decimal AdditionalCharge = 1;

        public enum Shape
        {
            Square,
            Triangle,
            Circle
        }

        public enum Colour
        {
            Red,
            Blue,
            Yellow
        }

        public static List<Shape> AvailableShapes => (List<Shape>) Enum.GetValues(typeof(Shape)).Cast<Shape>();
        public static List<Colour> AvailableColours => (List<Colour>) Enum.GetValues(typeof(Colour)).Cast<Colour>();

        public static decimal GetShapePrice(Enum shape)
        {
            return shape switch
            {
                Shape.Triangle => TrianglePrice,
                Shape.Circle => CirclePrice,
                Shape.Square => SquarePrice,
                _ => throw new NotImplementedException()
            };
        }
    }
}
