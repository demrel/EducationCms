using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Consumers
{
    public class ConsumerAddVM
    {
        public ConsumerModel Add { get; set; }
        public IFormFile Image { get; set; }
        public SelectList Seminars { get; set; }
    }
}
