using EducationCms.Data.Model.Posts;
using EducationCms.Service.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface.PostInterface
{
    public interface IBlog :IBase<Blog>
    {
        Task<List<Blog>> GetAllForList();
        Task<List<Blog>> GetByCategory(int id, int take);
        Task<List<Blog>> GetAllActive(BlogFilter filter);
        Task<int> Count(BlogFilter filter);
    }
}
