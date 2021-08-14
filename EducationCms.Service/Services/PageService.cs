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

        public async Task<Page> GetByName(string name)
        {
           return await  _context.Pages.FirstOrDefaultAsync(p => p.Name == name);
        }

        public async Task Stared(int id)
        {
            var data=await  _context.Pages.FirstOrDefaultAsync(p => p.Id == id);
            data.IsStared = !data.IsStared;
            _context.Update(data);
            _context.SaveChanges();
        }

        public async Task<List<Page>> GetAllStared()
        {
            return await _context.Pages.Where(p => p.IsStared).ToListAsync();
        }
    }
}
