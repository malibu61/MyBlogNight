using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Context;
using MyBlogNight2.DataAccessLayer.Repositories;
using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }

        public int ArticleCountByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.AppUserId == id).Count();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).Include(x => x.AppUser).ToList();
            return values;
        }

        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).Include(z => z.AppUser).FirstOrDefault();
            return values;
        }

        public List<Article> ArticleRecentThree()
        {
            var context = new BlogContext();
            var values = context.Articles.OrderBy(x => x.ArticleId).Take(3).ToList();
            return values;
        }

        public void ArticleViewCountIncrease(int id)//Sayfaya her girildiğinde 1 artırma olayı
        {
            var context = new BlogContext();
            var updatedValue = context.Articles.Find(id);
            updatedValue.ArticleViewCount += 1;
            context.SaveChanges();
        }

        public List<Article> ArticleWithCategory()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<CategoryArticleCountViewModel> CategoryCountArticle()
        {
            var context = new BlogContext();
            var values = context.Articles.GroupBy(x => new { x.CategoryId, x.Category.CategoryName }).Select(x => new CategoryArticleCountViewModel
            {
                CategoryId = x.Key.CategoryId,
                CategoryName = x.Key.CategoryName,
                ArticleCount = x.Count()
            }).OrderByDescending(x => x.ArticleCount).ToList();



            return values;
        }

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public int UserIdWithArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Select(x => x.AppUserId).FirstOrDefault();
            return values;
        }
    }
}
