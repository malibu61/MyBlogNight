using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultPopularCategoriesListComponentPartial: ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;


        public _DefaultPopularCategoriesListComponentPartial(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TCategoryCountArticle();
            return View(values);
        }
    }
}
