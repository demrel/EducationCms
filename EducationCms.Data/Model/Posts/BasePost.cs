using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("BasePost")]
    public class BasePost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int BannerImageId { get; set; }
        public AppImage BannerImage { get; set; }

        public DateTime Time { get; set; }
        public PostType Type { get; set; }
    }
}
