using EducationCms.Data.Data;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Filters;
using EducationCms.Service.Interface.PostInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services.Posts
{
    public class BlogService : BaseService<Blog>,IBlog
    {
        public BlogService(AppDBContext context) : base(context) { }

        public async Task<List<Blog>> GetByCategory(int id,int take)
        {
            return await _context.Blogs.Where(b => b.CategoryId == id && b.IsActive).Take(take).ToListAsync();
        }


        public async Task<List<Blog>> GetAllActive(BlogFilter filter)
        {
            var query =  _context.Blogs.Where(b => b.IsActive);

            if (!string.IsNullOrWhiteSpace(filter.Title))
                query = query.Where(b => EF.Functions.ILike(b.Title, $"%{filter.Title}%"));


            if (!string.IsNullOrWhiteSpace(filter.CategoryName))
                query = query.Where(b => EF.Functions.ILike(b.Cateogry.Name, $"%{filter.CategoryName}%"));

            return await query.ToListAsync();
        }


        public async Task<List<Blog>> GetLast(int take)
        {
            var query = _context.Blogs.Include(b=>b.BannerImage).Where(b => b.IsActive).Take(take);
            return await query.ToListAsync();
        }


        public async  Task<int> Count(BlogFilter filter)
        {
            var query = _context.Blogs.Where(b => b.IsActive);

            if (!string.IsNullOrWhiteSpace(filter.Title))
                query = query.Where(b => EF.Functions.ILike(b.Title, $"%{filter.Title}%"));

            if (!string.IsNullOrWhiteSpace(filter.CategoryName))
                query = query.Where(b => EF.Functions.ILike(b.Cateogry.Name, $"%{filter.CategoryName}%"));

            return await query.CountAsync();
        }

        public async Task<List<Blog>> GetAllForList()
        {
            return await  _context.Blogs.Select(b => new Blog()
            {
                Id = b.Id,
                BannerImage = b.BannerImage,
                Cateogry = b.Cateogry,
                Title = b.Title,
                IsActive=b.IsActive
                
            }).ToListAsync();
             
        }

        public new async Task<Blog> GetById(int id)
        {
            return await _context.Set<Blog>().Include(b=>b.BannerImage).FirstOrDefaultAsync(b=>b.Id==id);
        }

    }
}
