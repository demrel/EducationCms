using EducationCms.Web.Areas.admin.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Blog
{
    public class BlogModel : BasePostModel
    {
        public string Content { get; set; }
        public int  CategoryId { get; set; }
    }
}
