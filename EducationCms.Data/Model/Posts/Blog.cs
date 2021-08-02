using EducationCms.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Data.Model.Posts
{
    [Table("Blog")]
    public class Blog : BasePost
    {
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public Category Cateogry { get; set; }

        
        public Blog()
        {
            Type = PostType.Blog;
        }
    }
}
