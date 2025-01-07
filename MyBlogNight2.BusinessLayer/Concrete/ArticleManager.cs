using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.EntityFramework;
using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public int TArticleCountByAppUserId(int id)
        {
            return _articleDal.ArticleCountByAppUserId(id);
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
            return _articleDal.ArticleListWithCategoryAndAppUser();
        }

        public Article TArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            return _articleDal.ArticleListWithCategoryAndAppUserByArticleId(id);
        }

        public List<Article> TArticleRecentThree()
        {
            return _articleDal.ArticleRecentThree();
        }

        public void TArticleViewCountIncrease(int id)
        {
            _articleDal.ArticleViewCountIncrease(id);
        }

        public List<Article> TArticleWithCategory()
        {
            return _articleDal.ArticleWithCategory();
        }

        public List<CategoryArticleCountViewModel> TCategoryCountArticle()
        {
            return _articleDal.CategoryCountArticle();
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> TGetArticlesByAppUserId(int id)
        {
            return _articleDal.GetArticlesByAppUserId(id);
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }

        public int TUserIdWithArticleId(int id)
        {
            return _articleDal.UserIdWithArticleId(id);
        }
    }
}
