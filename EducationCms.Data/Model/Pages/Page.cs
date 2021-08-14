using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Pages
{
    public class Page
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Title2 { get; set; }
        public string Description2 { get; set; }

        public string Title3 { get; set; }
        public string Description3 { get; set; }

        public string Title4 { get; set; }
        public string Description4 { get; set; }

        public string Icon { get; set; }
        public bool IsStared { get; set; }
    }
}
