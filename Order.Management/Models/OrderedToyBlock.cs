using static Order.Management.Models.Constants;

namespace Order.Management.Models
{
    public class OrderedToyBlock
    {
        public Shape Shape { get; set; }
        public Colour Colour { get; set; }
        public int Quantity { get; set; }
    }
}
