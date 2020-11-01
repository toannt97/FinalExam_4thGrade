using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SalemanId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Status { get; set; }

        public virtual User Customer { get; set; }
        public virtual User Saleman { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
