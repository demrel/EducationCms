using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.TizerVideoPlaces
{
    public class TizerVIdeoAddVM
    {
        public TizerVideoPlaceModel Add { get; set; }
        public IFormFile ImageSquare { get; set; }
        public IFormFile ImageRect { get; set; }

    }
}
