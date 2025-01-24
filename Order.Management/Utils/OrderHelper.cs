using Order.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Order.Management.Models.Constants;

namespace Order.Management.Utils
{
    static class OrderHelper
    {
        public static int GetQuantityByShape(this Models.Order order, Shape shape)
        {
            return order.OrderedBlocks.Where(block => block.Colour.Equals(shape)).ToList().Sum(block => block.Quantity);
        }
        public static int GetQuantityByColour(this Models.Order order, Colour colour)
        {
            return order.OrderedBlocks.Where(block => block.Colour.Equals(colour)).ToList().Sum(block => block.Quantity);
        }

        public static int GetQuantityByShapeAndColour(this Models.Order order, Shape shape, Colour colour)
        {
            return order.OrderedBlocks.Where(block => block.Shape.Equals(shape) && block.Colour.Equals(colour)).ToList().Sum(block => block.Quantity);
        }

        
    }
}
