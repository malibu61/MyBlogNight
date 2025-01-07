using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
