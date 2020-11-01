using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class User
    {
        public User()
        {
            History = new HashSet<History>();
            OrderCustomer = new HashSet<Order>();
            OrderSaleman = new HashSet<Order>();
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }

        public virtual Role RoleNavigation { get; set; }
        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Order> OrderCustomer { get; set; }
        public virtual ICollection<Order> OrderSaleman { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
