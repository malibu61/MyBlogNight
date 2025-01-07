using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.EntityLayer.Concrete
{
    public class NewsletterSubscriber
    {
        [Key]
        public int NSId { get; set; }
        public string NSEmail { get; set; }
    }
}
