using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Pages
{
    public class MissionVision
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ImageId { get; set; }
        public AppImage Image { get; set; }
        public MissionVisionType Type { get; set; }
    }

}
