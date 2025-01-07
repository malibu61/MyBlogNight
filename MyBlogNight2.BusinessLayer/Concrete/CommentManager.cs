using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> TCommentsListByArticleId(int id)
        {
            return _commentDal.CommentsListByArticleId(id);
        }

        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }

        public List<Comment> TGetAll()
        {
            return _commentDal.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByAppUserId(int id)
        {
            return _commentDal.GetCommentsByAppUserId(id);
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            return _commentDal.GetCommentsByArticleId(id);
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
