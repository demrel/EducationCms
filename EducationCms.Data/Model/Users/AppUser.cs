using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Users
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public int? ImageId { get; set; }
        public AppImage Image { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public bool IsActive { get; set; }

      
    }
}
