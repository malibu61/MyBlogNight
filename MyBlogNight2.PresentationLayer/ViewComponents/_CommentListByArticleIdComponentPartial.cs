using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _CommentListByArticleIdComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListByArticleIdComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _commentService.TGetCommentsByArticleId(1);
            return View(values);
        }
    }
}
