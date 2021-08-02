using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Pages
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int ImageId { get; set; }
        public bool IsActive { get; set; }
        public AppImage Image { get; set; }
    }
}
