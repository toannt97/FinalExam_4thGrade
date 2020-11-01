//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using MyStore.Models.Tool;
//using Shop_Core.Models;
//using Shop_Core.Models.DataModels;

//namespace ShopWebApp.Controllers
//{
//    public class GioHangController : Controller
//    {
//        private readonly IEnumerable<Product> sanPhams_All;
//        private readonly IEnumerable<Brand> hangs_All;
//        public GioHangController()
//        {
//            //// HTTP GET
//            //HttpClient client = new HttpClient();
//            ////client.BaseAddress = new Uri(Program.localhost);
//            //HttpResponseMessage response = client.GetAsync("api/TechnologyFirms").Result;
//            //var hangs = response.Content.ReadAsAsync<IEnumerable<Brand>>().Result;
//            //response = client.GetAsync("api/sanpham").Result;
//            //var sanPhams = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
//            //foreach (var item_Sanpham in sanPhams)
//            //{
//            //    foreach (var item_Hang in hangs)
//            //    {
//            //        if (item_Hang.Id == item_Sanpham.FirmId)
//            //            item_Sanpham.FirmName = item_Hang.FirmName;
//            //    }
//            //}
//            //sanPhams_All = sanPhams;
//            //hangs_All = hangs;
//        }
//        public List<CartItem> GioHang
//        {
//            //get
//            //{
//            //    var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
//            //    if (gh == default(List<CartItem>))
//            //    {
//            //        gh = new List<CartItem>();
//            //    }
//            //    return gh;
//            //}
//        }
//        public IActionResult Index() //Hiển thị danh sách hàng trong giỏ hàng
//        {
//            ////Đọc SS giỏ hàng  
//            //List<Brand> Hangs = hangs_All.ToList();
//            //ViewBag.Hangs = Hangs;
//            ////ViewBag.domainUrl = Program.domainUrl;
//            //return View(GioHang);
//        }
//        public IActionResult AddToCart(int Id, int? soLuong)
//        {
//            //List<CartItem> gioHang = GioHang;
//            ////Thêm
//            //CartItem item = gioHang.SingleOrDefault(p => p.SanPhamChonMua.Id == Id);
//            //if (item != null)  //Đã có Item nên chỉ cần cập nhật số lượng
//            //{
//            //    if (soLuong.HasValue)
//            //    {
//            //        item.SoLuong = soLuong.Value;
//            //    }
//            //    else
//            //    {
//            //        item.SoLuong++;
//            //    }
//            //}
//            //else //Trường hợp chưa có nên cần tạo mới
//            //{
//            //    var sanPham = sanPhams_All.SingleOrDefault(p => p.Id == Id);
//            //    item = new CartItem
//            //    {
//            //        SoLuong = soLuong.HasValue ? soLuong.Value : 1,
//            //        SanPhamChonMua = sanPham
//            //    };
//            //    gioHang.Add(item); //Thêm vào giỏ
//            //}
//            ////Lưu lại Session
//            //HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
//            //return RedirectToAction("Index");
//        }
//        public IActionResult RemoveAll()  //Xoa tất cả
//        {
//            HttpContext.Session.Remove("GioHang");
//            return RedirectToAction("Index");
//        }
//        public IActionResult ClearCart()  //Xoa tất cả
//        {
//            HttpContext.Session.Remove("GioHang");
//            return RedirectToAction("Index");
//        }
//        public IActionResult Remove(int maSp) //Xóa 1 item
//        {
//            List<CartItem> gioHang = GioHang;
//            CartItem item = gioHang.SingleOrDefault(p => p.SanPhamChonMua.Id == maSp);
//            if (item != null)
//            {
//                gioHang.Remove(item);
//            }
//            //Lưu lại Session
//            HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
//            return RedirectToAction("Index");
//        }
//        public IActionResult RemoveCart(int maSp) //Xóa 1 item
//        {
//            List<CartItem> gioHang = GioHang;
//            CartItem item = gioHang.SingleOrDefault(p => p.SanPhamChonMua.Id == maSp);
//            bool kq = false;
//            if (item != null)
//            {
//                kq = gioHang.Remove(item);
//            }
//            //Lưu lại Session
//            HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
//            return Json(new { SoLuong = GioHang.Sum(p => p.SoLuong), TongTien = GioHang.Sum(p => p.ThanhTien), Status = kq });
//        }
//        [HttpPost]
//        public IActionResult UpdateCart(int[] productList, int[] amountList)
//        {
//            //List<CartItem> myCart = GioHang;
//            //CartItem item = null;
//            //bool kq = false;
//            //for (int i = 0; i < productList.Length; i++)
//            //{
//            //    item = myCart.SingleOrDefault(p => p.SanPhamChonMua.Id == productList[i]);
//            //    if (item != null)
//            //    {
//            //        item.SoLuong = amountList[i];
//            //        kq = true;
//            //    }
//            //}
//            //HttpContext.Session.Set("GioHang", myCart);
//            //return Json(new { SoLuong = GioHang.Sum(p => p.SoLuong), TongTien = GioHang.Sum(p => p.ThanhTien), Status = kq });
//        }
//        [HttpPost]
//        public async Task<IActionResult> Payment(string hoTen, string sdt, string email, string diaChi)
//        {
//            //if(ModelState.IsValid)
//            //{
//            //    KhachHang model = new KhachHang()
//            //    {
//            //        FullName = hoTen,
//            //        Phone = sdt,
//            //        Email = email,
//            //        Password = "123456789",
//            //        Address = diaChi
//            //    };
//            //    // HTTP GET
//            //    HttpClient client = new HttpClient();
//            //    //client.BaseAddress = new Uri(Program.localhost);
//            //    string api_str = "api/khachhang/sdt" + "/" + model.Phone;
//            //    HttpResponseMessage response = client.GetAsync(api_str).Result;
//            //    var khachHang = response.Content.ReadAsAsync<KhachHang>().Result;              
//            //    if (response.IsSuccessStatusCode == true) //Nếu hiện đã tồn tại sdt, update thông tin khách hàng
//            //    {
//            //        // HTTP PUT
//            //        model.Id = khachHang.Id;
//            //        api_str = "api/khachhang" + "/" + model.Id;
//            //        response = await client.PutAsJsonAsync(api_str, model);
//            //    }
//            //    else                                      //Nếu không tồn tại, tạo mới khách hàng
//            //    {
//            //        // HTTP POST
//            //        response = await client.PostAsJsonAsync("api/khachhang", model);
//            //        model = response.Content.ReadAsAsync<KhachHang>().Result;
//            //    }
//            //    if (model.Id != 0)
//            //    {
//            //        try
//            //        {
//            //            //Tạo đơn hàng
//            //            DonHang donHang = new DonHang
//            //            {
//            //                IdKh = model.Id,
//            //                IdNv = 1,
//            //                NgayLap = DateTime.Now,
//            //                NgayGiao = DateTime.Now.AddDays(3),
//            //                TongTien = GioHang.Sum(p => p.ThanhTien),
//            //                TinhTrang = "dangxuly",
//            //            };
//            //            response = await client.PostAsJsonAsync("api/donhang", donHang);
//            //            var tempDonHang = response.Content.ReadAsAsync<DonHang>().Result;
//            //            donHang.Id = tempDonHang.Id;
//            //            //Tạo chi tiết đơn hàng (Duyệt qua từng phần tử của giỏ hàng
//            //            ChiTietDh chiTietDh = null;

//            //            foreach (var item in GioHang)
//            //            {
//            //                chiTietDh = new ChiTietDh
//            //                {
//            //                    IdDh = donHang.Id,
//            //                    IdSp = item.SanPhamChonMua.Id,
//            //                    SoLuong = item.SoLuong,
//            //                    DonGia = item.SanPhamChonMua.UnitPrice,
//            //                    TenSP = item.SanPhamChonMua.product,
//            //                };
//            //                response = await client.PostAsJsonAsync("api/ChiTietDh", chiTietDh);
//            //            }
//            //            //Xóa Session
//            //            ClearCart();
//            //            //Gọi view hiển thị thông báo
//            //            ViewBag.ThongBao = "Đặt hàng thành công";
//            //        }
//            //        catch (Exception ex)
//            //        {
//            //            ViewBag.ThongBao = "Có lỗi khi lập hóa đơn, mời thử lại";
//            //        }
//            //    }
//            //    else
//            //    {
//            //        ViewBag.ThongBao = "Có lỗi hệ thống thông tin khách hàng";
//            //    }            
//            //    List<Brand> Hangs = hangs_All.ToList();
//            //    ViewBag.Hangs = Hangs;
//            //    return View();
//            //}                      
//            return View();
//        }
//    }
//}