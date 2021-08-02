using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("Video")]
    public class Video :BasePost
    {
        public string VideoUrl { get; set; }
        public Video()
        {
            Type = PostType.Video;
        }
    }
}
