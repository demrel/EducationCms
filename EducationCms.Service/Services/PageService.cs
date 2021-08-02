using EducationCms.Data.Data;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class PageService : BaseService<Page>,IPage
    {
        public PageService(AppDBContext context) : base(context) { }

        public Task<Page> GetByName(string name)
        {
           return _context.Pages.FirstOrDefaultAsync(p => p.Name == name);
        }
    }
}
