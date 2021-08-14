using EducationCms.Data.Model.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface
{
    public interface IPage :IBase<Page>
    {
        Task<Page> GetByName(string name);
        Task Stared(int id);
        Task<List<Page>> GetAllStared();
    }
}
