using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
