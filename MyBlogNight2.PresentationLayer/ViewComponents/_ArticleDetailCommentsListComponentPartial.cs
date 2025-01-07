using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _ArticleDetailCommentsListComponentPartial : ViewComponent
    {
        private readonly ICommentService commentService;

        public _ArticleDetailCommentsListComponentPartial(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public IViewComponentResult Invoke(int id = 1)
        {
            var values = commentService.TCommentsListByArticleId(id);
            return View(values);
        }
    }
}
