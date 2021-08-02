using EducationCms.Web.Areas.admin.Models.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Blog
{
    public class BlogAddVM :BasePostAddVM<BlogModel>
    {
       
        public SelectList Categories { get; set; }
    
    }

}
