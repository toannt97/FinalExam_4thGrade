using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.DataModels
{
    public class NhanVien
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
        [Required]
        [Display(Name = "Nhóm quyền")]
        public string NhomQuyen { get; set; }
    }
}
