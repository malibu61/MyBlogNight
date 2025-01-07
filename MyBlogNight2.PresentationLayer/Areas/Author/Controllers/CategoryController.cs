using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.EntityLayer.Concrete;

namespace MyBlogNight2.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        private readonly UserManager<AppUser> _userManager;

        public CategoryController(ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            _categoryService = categoryService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
