using EducationCms.Web.Areas.admin.Models;
using EducationCms.Web.Areas.admin.Models.Banners;
using EducationCms.Web.Areas.admin.Models.Blog;
using EducationCms.Web.Areas.admin.Models.Faqs;
using EducationCms.Web.Areas.admin.Models.MissionVisions;
using EducationCms.Web.Areas.admin.Models.Pages;
using EducationCms.Web.Areas.admin.Models.SIteSettings;
using EducationCms.Web.Areas.admin.Models.TizerVideoPlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Models
{
    public class HomeVM
    {
       public List<BannerModel> Banners { get; set; }
       public PageModel Page { get; set; }
       public List<PageModel> StarredPage { get; set; }
       public MissionVissionModel MV { get; set; }
       public TizerVideoPlaceModel TizerVideo { get; set; }
       public List<FaqModel> Faqs { get; set; }
       public List<BlogModel> Blogs { get; set; }
       public List<BasePostModel> LastVideos { get; set; }
        public SiteSettingsModel SiteSettings { get; set; }

        public HomeVM()
        {
            Banners = new();
            StarredPage = new();
            Faqs = new();
            Blogs = new();
            LastVideos = new();
        }
    }
}
