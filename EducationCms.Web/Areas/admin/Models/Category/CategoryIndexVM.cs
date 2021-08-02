using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Category
{
    public class CategoryIndexVM
    {
        public List<CategoryModel> Categories { get; set; }
        public CategoryModel Add { get; set; }
    }
}
