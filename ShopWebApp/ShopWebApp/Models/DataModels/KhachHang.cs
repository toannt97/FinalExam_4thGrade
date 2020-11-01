using System;
using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.DataModels
{
    public class KhachHang
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Họ tên")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Required]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ngày Lập")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Display(Name = "Ngày Update")]
        public DateTime UpdateDate { get; set; }
        [Display(Name = "Trạng Thái")]
        public string Status { get; set; }
    }
}
