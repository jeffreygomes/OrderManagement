using Order.Management.Models;
using System;
using System.Collections.Generic;
using static Order.Management.Models.Constants;

namespace Order.Management.Utilities
{
    public static class UserInputHelper
    {
        // Get Customer Info
        public static (string customerName, string address, DateTime dueDate) CaptureCustomerInfo()
        {
            Console.Write("Please input your Name: ");
            var customerName = GetStringInput();
            Console.Write("Please input your Address: ");
            var address = GetStringInput();
            Console.Write("Please input your Due Date: ");
            var dueDate = GetDateInput();
            return (customerName, address, dueDate);
        }

        // Get Customer's Order for Toy Blocks
        public static List<OrderedToyBlock> CaptureCustomerOrderedBlocks()
        {
            var orderedShapes = new List<OrderedToyBlock>();

            foreach (Shape shape in AvailableShapes)
            {
                Console.WriteLine();
                foreach (Colour colour in AvailableColours)
                {
                    Console.Write($"Please input the number of {colour} {shape}s: ");
                    var quantity = GetNumberInput();
                    orderedShapes.Add(new OrderedToyBlock()
                    {
                        Shape = shape,
                        Colour = colour,
                        Quantity = quantity
                    });
                }
            }

            return orderedShapes;
        }


        // Capturing different types of User Input
        private static string GetStringInput()
        {
            string inputString = Console.ReadLine();
            while (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("Please enter valid details");
                inputString = Console.ReadLine();
            }

            return inputString;
        }

        private static int GetNumberInput()
        {
            string inputString = Console.ReadLine();
            int inputNumber;
            while (!Int32.TryParse(inputString, out inputNumber) && string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Please enter a valid number");
                inputString = Console.ReadLine();
            }

            return inputNumber;
        }

        private static DateTime GetDateInput()
        {
            string inputString = Console.ReadLine();
            DateTime inputDate;
            while (!DateTime.TryParse(inputString, out inputDate) && string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Please enter a valid date");
                inputString = Console.ReadLine();
            }

            return inputDate;
        }
    }
}
