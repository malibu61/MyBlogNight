using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> ArticleWithCategory();
        List<Article> ArticleListWithCategoryAndAppUser();
        Article ArticleListWithCategoryAndAppUserByArticleId(int id);
        void ArticleViewCountIncrease(int id);
        List<Article> GetArticlesByAppUserId(int id);
        List<Article> ArticleRecentThree();
        List<CategoryArticleCountViewModel> CategoryCountArticle();
        int UserIdWithArticleId(int id);
        int ArticleCountByAppUserId(int id);
    }
}
