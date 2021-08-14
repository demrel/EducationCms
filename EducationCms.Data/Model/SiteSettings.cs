using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model
{
    public class SiteSettings
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public DateTime BuisnesStartTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ContactTitle { get; set; }
    }
}
