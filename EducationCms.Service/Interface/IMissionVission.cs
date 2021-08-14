using EducationCms.Data.Enums;
using EducationCms.Data.Model.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface
{
    public interface IMissionVission :IBase<MissionVision>
    {
        Task<MissionVision> Get(MissionVisionType type);
    }
}
