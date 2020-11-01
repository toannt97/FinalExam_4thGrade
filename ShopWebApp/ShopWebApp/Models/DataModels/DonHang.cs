using System;
using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.DataModels
{
    public class DonHang
    {
        public int Id { get; set; }
        
        [MaxLength(150)]
        [Display(Name = "Họ tên khách hàng")]
        public string HoTen_Kh { get; set; }
        [MaxLength(150)]
        [Display(Name = "Họ tên nhân viên")]
        public string HoTen_Nv { get; set; }
        [Display(Name = "Ngày lập")]
        public DateTime NgayLap { get; set; }
        [Required]
        [Display(Name = "Ngày giao")]
        public DateTime NgayGiao { get; set; }
        [Display(Name = "Tổng tiền")]
        public double TongTien { get; set; }
        [Required]
        [Display(Name = "Tình trạng")]
        public string TinhTrang { get; set; }
        [Required]
        [Display(Name = "Mã khách hàng")]
        public int IdKh { get; set; }
        [Required]
        [Display(Name = "Mã nhân viên")]
        public int IdNv { get; set; }
    }
}
