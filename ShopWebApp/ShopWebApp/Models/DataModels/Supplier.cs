using System;
using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.DataModels
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Brand name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Create date")]
        [Required]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Update date")]
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
