using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
