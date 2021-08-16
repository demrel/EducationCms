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
    public class TizerVideoService : BaseService<TizerVideoPlace>, ITizerVideo
    {
        public TizerVideoService(AppDBContext context) : base(context)
        {
           
        }

        public async Task<TizerVideoPlace> Get()=> await _context.TizerVideoPlaces.Include(t=>t.ImageRect).Include(t=>t.ImageSquare).FirstOrDefaultAsync();
        
    }
}
