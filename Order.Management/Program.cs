using Order.Management.Utilities;

namespace Order.Management
{
    class Program
    {
        // Main entry
        static void Main(string[] args)
        {
            var (customerName, address, dueDate) = UserInputHelper.CaptureCustomerInfo();

            var orderedBlocks = UserInputHelper.CaptureCustomerOrderedBlocks();

            var order = new Models.Order()
            {
                CustomerName = customerName,
                Address = address,
                DueDate = dueDate,
                OrderNumber = OrderHelper.GenerateOrderNumber(),
                OrderedBlocks = orderedBlocks,
            };

            ReportHelper.GenerateInvoiceReport(order);

            ReportHelper.GenerateCuttingListReport(order);

            ReportHelper.GeneratePaintingReport(order);
        }
    }
}
