using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Models.DataModels
{
    public class Status
    {
        public string LoaiTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
        public static List<Status> tinhTrangs = new List<Status>();
        public static void SetTinhTrang()
        {
            tinhTrangs.Clear();
            Status temp = new Status()
            {
                LoaiTinhTrang = "dangxuly",
                TenTinhTrang = "Đang xử lý"
            };
            Status temp2 = new Status()
            {
                LoaiTinhTrang = "hoantat",
                TenTinhTrang = "Hoàn tất"
            };
            tinhTrangs.Add(temp);
            tinhTrangs.Add(temp2);
        }
        
    }
}
