using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetCommentsByArticleId(int id);
        List<Comment> GetCommentsByAppUserId(int id);
        List<Comment> CommentsListByArticleId(int id);
        List<Comment> CommentWithAuthorByArticleId(int id);

    }
}
