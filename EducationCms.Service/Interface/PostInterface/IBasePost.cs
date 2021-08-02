using EducationCms.Data.Model.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface.PostInterface
{
    public interface IBasePost<T> : IBase<T>
    {
        Task<List<T>> GetAllActive();
        Task ActivateDeactivate(int id);
    }
}
