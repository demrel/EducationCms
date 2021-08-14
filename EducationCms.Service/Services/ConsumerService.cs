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
    public class ConsumerService : BaseService<Consumer>, IConsumer
    {
        public ConsumerService(AppDBContext context) : base(context) { }

        public async Task Stared(int id)
        {
            var data = await _context.Consumers.FirstOrDefaultAsync(p => p.Id == id);
            data.IsStared = !data.IsStared;
            _context.Update(data);
            _context.SaveChanges();
        }
        public new  async Task<List<Consumer>> GetAll()
        {
            return await _context.Set<Consumer>().Include(c=>c.Image).ToListAsync();
        }
        public async Task<List<Consumer>> GetAllStared()
        {
            return await _context.Consumers.Where(p => p.IsStared).ToListAsync();
        }
    }
}
