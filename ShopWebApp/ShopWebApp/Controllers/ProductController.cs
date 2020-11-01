using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopWebApp.Common;
using ShopWebApp.Models;
using ShopWebApp.Models.DataModels;

namespace ShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _client = HttpClientAccessor.HttpClient;

        public async Task<IActionResult> Index(int? supplierId, int pageNo = 0)
        {
            if (!supplierId.HasValue)
            {
                supplierId = 0;
            }

            var response = await _client.GetAsync("suppliers");
            var suppliers = response.Content.ReadAsAsync<IEnumerable<Supplier>>().Result;
            response = await _client.GetAsync("products");
            var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            response = await _client.GetAsync("categories");
            var category = response.Content.ReadAsAsync<IEnumerable<Category>>().Result; 

            foreach (var product in products)
            {
                foreach (var supplier in suppliers)
                {
                    if (supplier.Id == product.SupplierId)
                        product.SupplierName = supplier.Name;
                }
            }
            var productResult = products.Where(p => (supplierId == 0) || (p.SupplierId == supplierId))
                .Skip(pageNo * Program.PAGE_SIZE)
                .Take(Program.PAGE_SIZE);
            var totals = productResult.Count();
            ViewBag.TotalPage = Math.Ceiling(1.0 * totals / Program.PAGE_SIZE);
            ViewBag.PageNumber = pageNo;
            ViewBag.Suppliers = suppliers.ToList();
            ViewBag.SupplierId = supplierId;
            ViewBag.Category = category;
            //ViewBag.domainUrl = Program.domainUrl;
            return View(productResult);
        }

    //    public IActionResult ChiTiet(int id)
    //    {
    //        // HTTP GET
    //        HttpClient client = new HttpClient();
    //        //client.BaseAddress = new Uri(Program.localhost);
    //        HttpResponseMessage response = client.GetAsync("api/TechnologyFirms").Result;
    //        var hangs = response.Content.ReadAsAsync<IEnumerable<Hang>>().Result;
    //        string api_str = "api/Products" + "/" + id;
    //        response = client.GetAsync(api_str).Result;
    //        var sanPham = response.Content.ReadAsAsync<SanPham>().Result;
    //        foreach (var item in hangs)
    //        {
    //            if (item.Id == sanPham.FirmId)
    //                sanPham.FirmName = item.FirmName;
    //        }
    //        if (sanPham == null)
    //        {
    //            return NotFound();
    //        }
    //        response = client.GetAsync("api/Products").Result;
    //        var sanPhams = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
    //        foreach (var item_Sanpham in sanPhams)
    //        {
    //            foreach (var item_Hang in hangs)
    //            {
    //                if (item_Hang.Id == item_Sanpham.FirmId)
    //                    item_Sanpham.FirmName = item_Hang.FirmName;
    //            }
    //        }
    //        List<SanPham> dsNgauNhien = sanPhams.Where(p => p.FirmId == sanPham.FirmId).Take(3).ToList();
    //        ViewBag.DSHangNgauNhien = dsNgauNhien;
    //        List<Hang> Hangs = hangs.ToList();
    //        ViewBag.Hangs = Hangs;
    //        //ViewBag.domainUrl = Program.domainUrl;
    //        return View(sanPham);
    //    }
    //    public IActionResult Search(string Keyword)
    //    {
    //        // HTTP GET
    //        HttpClient client = new HttpClient();
    //        //client.BaseAddress = new Uri(Program.localhost);
    //        HttpResponseMessage response = client.GetAsync("api/TechnologyFirms").Result;
    //        var hangs = response.Content.ReadAsAsync<IEnumerable<Hang>>().Result;
    //        response = client.GetAsync("api/Products").Result;
    //        var sanPhams = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
    //        foreach (var item_Sanpham in sanPhams)
    //        {
    //            foreach (var item_Hang in hangs)
    //            {
    //                if (item_Hang.Id == item_Sanpham.FirmId)
    //                    item_Sanpham.FirmName = item_Hang.FirmName;
    //            }
    //        }
    //        if (Keyword == null)
    //            Keyword = "";
    //        var dsSanPham = sanPhams.Where(p => p.product.Contains(Keyword)).Take(5).ToList();
    //        //ViewBag.domainUrl = Program.domainUrl;
    //        return PartialView("SearchPartial", dsSanPham);
    //    }
    }
}