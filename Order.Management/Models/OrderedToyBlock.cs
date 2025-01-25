using static Order.Management.Models.Constants;

namespace Order.Management.Models
{
    public class OrderedToyBlock
    {
        public Shape Shape { get; set; }
        public Color Color { get; set; }
        public int Quantity { get; set; }
    }
}
