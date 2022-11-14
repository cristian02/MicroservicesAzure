using System;
using System.Collections.Generic;

namespace MSAzure.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UpdatedTime { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
