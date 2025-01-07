using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _mainLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
