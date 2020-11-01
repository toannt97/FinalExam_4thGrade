using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
