using System;
using System.Collections.Generic;
using System.Text;
using static Order.Management.Models.Constants;

namespace Order.Management.Models
{
    public abstract class ToyBlock
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int AdditionalCharge { get; set; }
        public Shape Shape { get; set; }
        public Colour Colour { get; set; }
    }


}
