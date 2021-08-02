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
    public class BannerService : BaseService<Banner>, IBanner
    {
        public BannerService(AppDBContext context) : base(context) { }

        async Task<List<Banner>> IBase<Banner>.GetAll()
        {
            return await _context.Set<Banner>()
                .Include(b=>b.Image)
                .ToListAsync();
        }

        //public async Task<List<Banner>> GetAllActive()
        //{
        //    return await _context.Banners.Where(b=>b.IsActive).ToListAsync();
        //}

        //public async Task ActivateDeactivate(int id)
        //{
        //    var data =await GetById(id);
        //    data.IsActive = !data.IsActive;
        //   await _context.SaveChangesAsync();
        //}


    }
}
