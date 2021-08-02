using EducationCms.Data.Data;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class CategoryService : BaseService<Category>,ICategory
    {
        public CategoryService(AppDBContext context) : base(context) { }
        
    }
}
