using System;
using System.Linq;
using static Order.Management.Models.Constants;

namespace Order.Management.Utilities
{
    static class OrderHelper
    {
        public static int GetQuantityByShape(this Models.Order order, Shape shape)
        {
            return order.OrderedBlocks.Where(block => block.Shape.Equals(shape)).ToList().Sum(block => block.Quantity);
        }
        public static int GetQuantityByColour(this Models.Order order, Colour colour)
        {
            return order.OrderedBlocks.Where(block => block.Colour.Equals(colour)).ToList().Sum(block => block.Quantity);
        }
        public static int GetQuantityByShapeAndColour(this Models.Order order, Shape shape, Colour colour)
        {
            return order.OrderedBlocks.Where(block => block.Shape.Equals(shape) && block.Colour.Equals(colour)).ToList().Sum(block => block.Quantity);
        }        
        public static int GenerateOrderNumber()
        {
            // TODO: Change to generate proper order numbers
            var rnd = new Random();
            return rnd.Next(100);
        }
    }
}
