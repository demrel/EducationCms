using EducationCms.Data.Data;
using EducationCms.Data.Model;
using EducationCms.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class SiteSettingService : BaseService<SiteSettings>, ISiteSetting
    {
        public SiteSettingService(AppDBContext context) : base(context)
        {
        }

        public async Task<SiteSettings> Get() =>
           await _context.SiteSettings.FirstOrDefaultAsync();
    }
}
