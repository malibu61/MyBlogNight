using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetCommentsByArticleId(int id);
        public List<Comment> TGetCommentsByAppUserId(int id);
        public List<Comment> TCommentsListByArticleId(int id);
    }
}
