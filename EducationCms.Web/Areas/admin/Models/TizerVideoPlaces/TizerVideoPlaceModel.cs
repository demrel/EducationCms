using EducationCms.Web.Areas.admin.Models.AppImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.TizerVideoPlaces
{
    public class TizerVideoPlaceModel
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

        public AppImageModel ImageSquare { get; set; }
        public AppImageModel ImageRect { get; set; }
    }
}
