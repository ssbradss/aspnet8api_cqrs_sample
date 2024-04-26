using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyPhanQuyenNguoiDung
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public List<Quyen> danhSachQuyen { get; set; } = new List<Quyen>
    {
        new Quyen { STT = 1, Name = "Quyền 1", IsBuiltin = true },
        new Quyen { STT = 2, Name = "Quyền 2", IsBuiltin = false },
        new Quyen { STT = 3, Name = "Quyền 3", IsBuiltin = false },
    };

        public class Quyen
        {
            public int STT { get; set; }
            public string Name { get; set; } = default!;
            public bool IsBuiltin { get; set; }
        }

        private void Duplicatequyen(Quyen quyen)
        {
        }

        private void Deletequyen(Quyen quyen)
        {
        }
    }
}
