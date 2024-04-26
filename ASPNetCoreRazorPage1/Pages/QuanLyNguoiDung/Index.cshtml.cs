using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyNguoiDung
{
    public class IndexModel : PageModel
    {
        public ThongTinNguoiDung[]? thongTinNguoiDung;

        public void OnGet()
        {
            thongTinNguoiDung = new ThongTinNguoiDung[]
            {
            new ThongTinNguoiDung{ Email = "NguoiDung1@gmail.com", PhanQuyen = "PhanQuyen1", CapDo = "1", TrangThai = "TrangThai1"},
            new ThongTinNguoiDung{ Email = "NguoiDung2@gmail.com", PhanQuyen = "PhanQuyen2", CapDo = "2", TrangThai = "TrangThai2"},
            new ThongTinNguoiDung{ Email = "NguoiDung3@gmail.com", PhanQuyen = "PhanQuyen3", CapDo = "3", TrangThai = "TrangThai3"},
            new ThongTinNguoiDung{ Email = "NguoiDung4@gmail.com", PhanQuyen = "PhanQuyen4", CapDo = "4", TrangThai = "TrangThai4"}
            };
        }

        public class ThongTinNguoiDung
        {
            public string? Email { get; set; }

            public string? PhanQuyen { get; set; }

            public string? CapDo { get; set; }

            public string? TrangThai { get; set; }
        }
    }
}
