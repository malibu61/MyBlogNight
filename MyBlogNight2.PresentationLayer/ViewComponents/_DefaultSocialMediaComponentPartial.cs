using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _DefaultSocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }
    }
}
