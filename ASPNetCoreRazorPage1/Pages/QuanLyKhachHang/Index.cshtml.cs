using ASPNetCoreRazorPage1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyKhachHang
{
    public class IndexModel : PageModel
    {
        public TestClass[]? Items;

        public void OnGet()
        {
            Items = new TestClass[]
            {
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"},
            new TestClass{ TestField1 = "TenChuongTrinh"}
            };
        }
    }
}
