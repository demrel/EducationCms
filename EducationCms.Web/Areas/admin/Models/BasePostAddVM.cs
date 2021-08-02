using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models
{
    public class BasePostAddVM<T> where T:BasePostModel
    {
        public T Add { get; set; }
        public IFormFile Image { get; set; }
    }
}
