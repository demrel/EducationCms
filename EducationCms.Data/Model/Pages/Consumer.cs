using EducationCms.Data.Model.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Pages
{
    public class Consumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Review { get; set; }

        public int? SeminarId { get; set; }
        public Seminar Seminar { get; set; }

        public bool IsStared { get; set; }

        public int?  ImageId { get; set; }
        public AppImage Image { get; set; }
    }
}
