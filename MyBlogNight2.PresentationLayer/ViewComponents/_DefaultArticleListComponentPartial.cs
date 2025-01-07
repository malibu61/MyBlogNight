using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
