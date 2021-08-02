using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("FileShare")]
    public class FileShare :BasePost
    {
        public string FileUrl { get; set; }
        public FileShare()
        {
            Type = PostType.File;
        }
    }
}
