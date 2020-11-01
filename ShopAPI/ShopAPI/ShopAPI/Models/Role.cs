using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            Category = new HashSet<Category>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
