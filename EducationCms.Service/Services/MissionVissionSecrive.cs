using EducationCms.Data.Data;
using EducationCms.Data.Enums;
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
    public class MissionVissionSecrive : BaseService<MissionVision>, IMissionVission
    {
        public MissionVissionSecrive(AppDBContext context) : base(context) { }
       
        public async Task<MissionVision> Get(MissionVisionType type)=>
          await  _context.MissionVisions.FirstOrDefaultAsync(mv => mv.Type == type);
      
        public new  async Task<List<MissionVision>> GetAll()=> await _context.MissionVisions.Include(m => m.Image).ToListAsync();
        

    }
}
