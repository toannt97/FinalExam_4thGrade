using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.ViewModels
{
    public class KhachHangViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
        [Display(Name = "Số điện thoại")]
        public string Sdt { get; set; }
        [Required]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("MatKhau", ErrorMessage = "Nhập lại mật khẩu Không khớp")]
        public string NhapLaiMatKhau { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
