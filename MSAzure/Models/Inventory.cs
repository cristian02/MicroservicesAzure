using System;
using System.Collections.Generic;

namespace MSAzure.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
    }
}
