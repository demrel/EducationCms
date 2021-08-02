using EducationCms.Data.Data;
using EducationCms.Data.Model.Posts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class BaseService<T> where T:class
    {
        protected AppDBContext _context;

        public BaseService(AppDBContext context)
        {
            _context = context;
        }

        public async Task Create(T item)
        {
             await  _context.AddAsync(item);
             await  _context.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }

        public void Delete(T item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public async Task  Delete(int id)
        {
           var data= await GetById(id);
            if (data == null) return;

            Delete(data);
            _context.SaveChanges();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
