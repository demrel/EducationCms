using EducationCms.Data.Model.Users;
using Microsoft.AspNetCore.Identity;

namespace TravelSystem.Data.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                AppUser user = new()
                {
                    UserName = "admin",
                };
               
                IdentityResult result = userManager.CreateAsync(user, "Admin1234").Result;

                if (result.Succeeded)
                {

                    AppRole roleAdmin = new () { Name = "admin" };
                  
                
                    roleManager.CreateAsync(roleAdmin).Wait();

                    userManager.AddToRoleAsync(user, "admin").Wait();
                }
            }
         
        }
  
    }
}
