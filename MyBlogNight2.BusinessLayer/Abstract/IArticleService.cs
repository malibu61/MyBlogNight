using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TArticleWithCategory();
        List<Article> TArticleListWithCategoryAndAppUser();
        public Article TArticleListWithCategoryAndAppUserByArticleId(int id);
        public void TArticleViewCountIncrease(int id);
        public List<Article> TGetArticlesByAppUserId(int id);
        public List<Article> TArticleRecentThree();
        List<CategoryArticleCountViewModel> TCategoryCountArticle();
        int TUserIdWithArticleId(int id);
        int TArticleCountByAppUserId(int id);
    }
}
