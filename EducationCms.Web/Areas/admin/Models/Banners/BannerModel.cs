using EducationCms.Web.Areas.admin.Models.AppImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Banners
{
    public class BannerModel
    {
        public int Id { get; set; }
        public string TitleFirst { get; set; }
        public string TitleSecond { get; set; }

        public string Url { get; set; }
        public AppImageModel Image { get; set; }
    }
}
