using EducationCms.Data.Data;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface.PostInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services.Posts
{
    public class ConsultingService : BasePostService<Consulting>, IConsulting
    {
        public ConsultingService(AppDBContext context) : base(context) { }

    }
    
}
