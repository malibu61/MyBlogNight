using Microsoft.AspNetCore.Mvc;
using X.PagedList.Mvc.Core;
using X.PagedList.Extensions;
using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.EntityLayer.Concrete;

namespace MyBlogNight2.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {

        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly INewsletterSubscriberService _newsletterSubscriberService;
        string ArticleIdGlobal = "1";

        public DefaultController(IArticleService articleService, ICommentService commentService, INewsletterSubscriberService newsletterSubscriberService)
        {
            _articleService = articleService;
            _commentService = commentService;
            _newsletterSubscriberService = newsletterSubscriberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_(int page = 1)
        {
            const int pageSize = 2;
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            var pagedArticles = values.ToPagedList(page, pageSize);
            return View(pagedArticles);
        }

        public IActionResult AddNewsletterSubscriber(NewsletterSubscriber newsletterSubscriber)
        {

            _newsletterSubscriberService.TInsert(newsletterSubscriber);
            return RedirectToAction("Index_");
        }

        public IActionResult ArticleDetails(int id)
        {
            ArticleIdGlobal = id.ToString();

            ViewBag.ArticleIdGlobal = id;

            _articleService.TArticleViewCountIncrease(id);
            var values = _articleService.TArticleListWithCategoryAndAppUserByArticleId(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult LeaveComment(Comment comment)
        {
            comment.Status = true;
            comment.ArticleId = int.Parse(ArticleIdGlobal.ToString());
            comment.CreatedDate = DateTime.Now;
            _commentService.TInsert(comment);
            return RedirectToAction("Index_");
        }

    }
}
