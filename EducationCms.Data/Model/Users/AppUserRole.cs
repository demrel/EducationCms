using Microsoft.AspNetCore.Identity;

namespace EducationCms.Data.Model.Users
{
    public class AppUserRole : IdentityUserRole<string>
    {
        public virtual AppUser User { get; set; }
        public virtual AppRole Role { get; set; }
    }
}