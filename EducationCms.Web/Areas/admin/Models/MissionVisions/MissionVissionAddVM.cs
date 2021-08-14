using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.MissionVisions
{
    public class MissionVissionAddVM
    {
        public MissionVissionModel Add { get; set; }
        public IFormFile Image { get; set; }
    }
}
