using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
