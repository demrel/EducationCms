using EducationCms.Web.Areas.admin.Models.AppImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Consumers
{
    public class ConsumerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Review { get; set; }
        public int? SeminarId { get; set; }
        public bool IsStared { get; set; }
        public AppImageModel Image { get; set; }
    }
}
