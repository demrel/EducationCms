using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("Consulting")]
    public class Consulting: BasePost
    {
        public string Content { get; set; }
        public Consulting()
        {
            Type = PostType.Consulting;
        }
    

    }
}
