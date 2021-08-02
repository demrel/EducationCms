using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("Seminar")]
    public  class Seminar :BasePost
    {
        public string Content { get; set; }
        public Seminar()
        {
            Type = PostType.Seminar;
        }
    }
}
