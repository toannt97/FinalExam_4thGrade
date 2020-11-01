﻿using System;
using System.Collections.Generic;

namespace ShopAPI.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; }
    }
}
