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
        public static int GetQuantityByColor(this Models.Order order, Color color)
        {
            return order.OrderedBlocks.Where(block => block.Color.Equals(color)).ToList().Sum(block => block.Quantity);
        }
        public static int GetQuantityByShapeAndColor(this Models.Order order, Shape shape, Color color)
        {
            return order.OrderedBlocks.Where(block => block.Shape.Equals(shape) && block.Color.Equals(color)).ToList().Sum(block => block.Quantity);
        }        
        public static int GenerateOrderNumber()
        {
            // TODO: Change to generate proper order numbers
            var rnd = new Random();
            return rnd.Next(100);
        }
    }
}
