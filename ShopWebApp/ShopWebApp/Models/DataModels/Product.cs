using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Models.DataModels
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Product name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Unit price")]
        public double UnitPrice { get; set; }
        [MaxLength(150)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Brand id")]
        public int SupplierId { get; set; }
        [Required]
        [Display(Name = "Branch name")]
        public string SupplierName { get; set; }
        [Display(Name = "Create date")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Update date")]
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
