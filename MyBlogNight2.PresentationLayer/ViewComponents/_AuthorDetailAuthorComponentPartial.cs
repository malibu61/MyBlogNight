using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _AuthorDetailAuthorComponentPartial : ViewComponent
    {
        private readonly IArticleService articleService;
        private readonly IAppUserService appUserService;

        public _AuthorDetailAuthorComponentPartial(IArticleService _articleService, IAppUserService _appUserService)
        {
            articleService = _articleService;
            appUserService = _appUserService;
        }

        public IViewComponentResult Invoke(int id = 1)
        {
            var values1 = articleService.TUserIdWithArticleId(id);
            var values2 = appUserService.TGetById(values1);
            return View(values2);
        }
    }
}
