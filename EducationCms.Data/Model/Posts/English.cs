using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("Service")]
    public class English : BasePost
    {
        public string Content { get; set; }
        public English()
        {
            Type = PostType.English;
        }
    }
}
