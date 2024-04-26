using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyChuongTrinh
{
    public class IndexModel : PageModel
    {
        public ThongTinChuongTrinh[]? thongTinChuongTrinh;

        public void OnGet()
        {
            thongTinChuongTrinh = new ThongTinChuongTrinh[]
            {
            new ThongTinChuongTrinh{ TenChuongTrinh = "TenChuongTrinh", TenToChuc = "TenToChuc", NgayTao = DateTime.Now, NguoiTao = "NguoiTao1", TrangThai = "TrangThai1"},
            new ThongTinChuongTrinh{ TenChuongTrinh = "TenChuongTrinh2", TenToChuc = "TenToChuc2", NgayTao = DateTime.Now, NguoiTao = "NguoiTao2", TrangThai = "TrangThai2"},
            new ThongTinChuongTrinh{ TenChuongTrinh = "TenChuongTrinh3", TenToChuc = "TenToChuc3", NgayTao = DateTime.Now, NguoiTao = "NguoiTao3", TrangThai = "TrangThai3"},
            new ThongTinChuongTrinh{ TenChuongTrinh = "TenChuongTrinh4", TenToChuc = "TenToChuc4", NgayTao = DateTime.Now, NguoiTao = "NguoiTao4", TrangThai = "TrangThai4"},
            };
        }

        public class ThongTinChuongTrinh
        {
            public string? TenChuongTrinh { get; set; }

            public string? TenToChuc { get; set; }
            public DateTime? NgayTao { get; set; }

            public string? NguoiTao { get; set; }

            public string? TrangThai { get; set; }
        }
    }
}
