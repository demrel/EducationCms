using EducationCms.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Interface
{
    public interface ISiteSetting: IBase<SiteSettings>
    {
        Task<SiteSettings> Get();
    }
}
