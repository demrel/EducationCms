using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Banners
{
    public class BannerAddEditVM
    {
        public BannerModel Add { get; set; }
        public IFormFile Image { get; set; }
    }
}
