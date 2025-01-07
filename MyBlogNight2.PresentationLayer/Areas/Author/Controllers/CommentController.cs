using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.EntityLayer.Concrete;

namespace MyBlogNight2.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;


        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCommentList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentService.TGetCommentsByAppUserId(user.Id);
            return View(values);
        }

        [HttpGet]
        public IActionResult EditMyComment(int id)
        {
            var values = _commentService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditMyComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return Redirect("/Author/Comment/MyCommentList");
        }

        public IActionResult DeleteMyComment(int id)
        {
            _commentService.TDelete(id);
            return Redirect("/Author/Comment/MyCommentList");
        }
    }
}
