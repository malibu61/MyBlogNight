using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
