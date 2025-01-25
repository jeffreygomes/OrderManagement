using System;
using System.Collections.Generic;
using System.Linq;

namespace Order.Management.Models
{
    public static class Constants
    {
        // Toy Block Prices
        public const decimal SquarePrice = 1;
        public const decimal TrianglePrice = 2;
        public const decimal CirclePrice = 3;

        public const decimal RedPaintAdditionalCharge = 1; // Only charged for Red color blocks

        // Toy Block Attributes
        public enum Shape
        {
            Square,
            Triangle,
            Circle
        }

        public enum Color
        {
            Red,
            Blue,
            Yellow
        }

        public static List<Shape> AvailableShapes => Enum.GetValues(typeof(Shape)).Cast<Shape>().ToList();
        public static List<Color> AvailableColors => Enum.GetValues(typeof(Color)).Cast<Color>().ToList();

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
