using EducationCms.Data.Model;
using EducationCms.Data.Model.Pages;
using EducationCms.Data.Model.Posts;
using EducationCms.Data.Model.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Data
{
    public class AppDBContext :IdentityDbContext<AppUser, AppRole, string, IdentityUserClaim<string>,
    AppUserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<AppImage> Images { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<BasePost> BasePosts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Maintance> Services { get; set; }
        public DbSet<FileShare> FileShare { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Seminar> Seminars { get; set; }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<Page> Pages { get; set; }

       
    }
}
