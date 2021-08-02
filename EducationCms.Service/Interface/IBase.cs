using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface
{
    public interface IBase<T>
    {
        Task Create(T item);
        Task Update(T item);
        void Delete(T item);
        Task Delete(int id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
