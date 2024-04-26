using ASPNetCoreRazorPage1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyKhachHang
{
    public class DetailModel : PageModel
    {
        public TestClass[]? Items;
        public TestClass Item { get; set; } = default!;

        public void OnGet()
        {
            Item = new TestClass() { TestField1 = "Nguyen Van A" };
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
