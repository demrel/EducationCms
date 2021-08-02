using EducationCms.Data.Data;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface.PostInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services.Posts
{
    public class BasePostService<T> : BaseService<T>,IBasePost<T> where T : BasePost
    {
        public BasePostService(AppDBContext context) : base(context) { }

        public async Task<List<T>> GetAllActive()
        {
          return await  _context.Set<T>().Where(t => t.IsActive).ToListAsync();
        }

        public new async Task Create(T item)
        {
            item.Time = DateTime.UtcNow.AddHours(4);
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task ActivateDeactivate(int id)
        {
            var data = await GetById(id);
            data.IsActive = !data.IsActive;
            _context.Update(data);
            await  _context.SaveChangesAsync();
        }
    }
}
