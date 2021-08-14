using EducationCms.Data.Enums;
using EducationCms.Web.Areas.admin.Models.AppImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.MissionVisions
{
    public class MissionVissionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public AppImageModel Image { get; set; }
        public MissionVisionType Type { get; set; }
    }
}
