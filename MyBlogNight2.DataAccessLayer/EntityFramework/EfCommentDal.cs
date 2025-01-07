using Microsoft.EntityFrameworkCore;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Context;
using MyBlogNight2.DataAccessLayer.Repositories;
using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }

        public List<Comment> CommentsListByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(x => x.AppUser).ToList();
            return values;
        }

        public List<Comment> CommentWithAuthorByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).ToList();
            return values;
        }

        public List<Comment> GetCommentsByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.AppUserId == id).Include(x=>x.Article).ToList();
            return values;
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
