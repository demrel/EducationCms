using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Models.Faqs
{
    public class FaqIndexVM
    {
        public List<FaqModel> Faqs { get; set; }
        public FaqModel Add { get; set; }
    }
}
