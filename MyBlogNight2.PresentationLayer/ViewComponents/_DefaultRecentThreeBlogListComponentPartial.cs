using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultRecentThreeBlogListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultRecentThreeBlogListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }


        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleRecentThree();
            return View(values);
        }
    }
}
