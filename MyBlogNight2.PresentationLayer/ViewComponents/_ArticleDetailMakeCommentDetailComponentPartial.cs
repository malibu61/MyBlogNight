using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _ArticleDetailMakeCommentDetailComponentPartial : ViewComponent
    {
        private readonly ICommentService commentService;

        public _ArticleDetailMakeCommentDetailComponentPartial(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var comment = new MyBlogNight2.EntityLayer.Concrete.Comment();
            return View(comment);

        }
    }
}
