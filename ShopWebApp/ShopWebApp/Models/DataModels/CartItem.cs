using System.ComponentModel.DataAnnotations;

namespace ShopWebApp.Models.DataModels
{
    public class CartItem
    {
        [Display(Name = "Sản phẩm chọn mua")]
        public Product SanPhamChonMua { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Thành tiền")]
        //public double ThanhTien => SoLuong * HangChonMua.DonGia;  //Toan tu tra ve gia tri Get
        public double ThanhTien => SoLuong * SanPhamChonMua.UnitPrice;
    }
}
