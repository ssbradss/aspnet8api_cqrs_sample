using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazorPage1.Pages.QuanLyPhanQuyenNguoiDung
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        public Dictionary<string, bool> groupStates = new Dictionary<string, bool>();
        public List<PermissionGroup> permissionGroups = new List<PermissionGroup>
    {
        new PermissionGroup
        {
            Name = "Quản lý chức năng",
            Permissions = new List<string> { "Quyền A", "Quyền B", "Quyền C" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock1",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock2",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock3",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock4",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock5",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        },
        new PermissionGroup
        {
            Name = "Quản lý tổ chức Mock6",
            Permissions = new List<string> { "Quyền D", "Quyền E" }
        }
    };

        public class PermissionGroup
        {
            public string Name { get; set; } = default!;
            public List<string> Permissions { get; set; } = default!;
        }

        private void ToggleGroup(string groupName)
        {
            if (groupStates.ContainsKey(groupName))
            {
                groupStates[groupName] = !groupStates[groupName];
            }
            else
            {
                groupStates[groupName] = true;
            }
        }

        private void ShowSelected()
        {
            // Xử lý hiển thị các nhóm chức năng đã chọn
        }

        private void ShowAll()
        {
            // Xử lý hiển thị tất cả các nhóm chức năng
        }

        private void SelectAll()
        {
            // Xử lý chọn tất cả các quyền trong nhóm đang mở
        }

        private void DeselectAll()
        {
            // Xử lý bỏ chọn tất cả các quyền trong nhóm đang mở
        }
    }
}
