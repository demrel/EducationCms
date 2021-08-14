using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Pages
{
    public class TizerVideoPlace
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionFirst { get; set; }
        public string DescriptionSecond { get; set; }
        public string ContactText { get; set; }
        public string PhoneNumber { get; set; }
        public string VideoUrl { get; set; }


        public string Value1 { get; set; }
        public int Percent1 { get; set; }

        public string Value2 { get; set; }
        public int Percent2 { get; set; }

        public int ImageSquareId { get; set; }
        public AppImage ImageSquare { get; set; }

        public int ImageRectId { get; set; }
        public AppImage ImageRect { get; set; }
    }
}
