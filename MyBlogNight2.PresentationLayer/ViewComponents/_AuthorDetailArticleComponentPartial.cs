using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.BusinessLayer.Abstract;

namespace MyBlogNight2.PresentationLayer.ViewComponents
{
    public class _AuthorDetailArticleComponentPartial : ViewComponent
    {
        private readonly IArticleService articleService;

        public _AuthorDetailArticleComponentPartial(IArticleService _articleService)
        {
            articleService = _articleService;
        }

        //public IViewComponentResult Invoke(int id)
        //{
        //    var values = articleService.TArticleListWithCategoryAndAppUserByArticleId(id);
        //    return View(values);
        //}

        public IViewComponentResult Invoke(int id)
        {
            var values = articleService.TArticleListWithCategoryAndAppUserByArticleId(id);

            // values null olmasın diye kontrol ekleyebilirsiniz
            if (values == null)
            {
                return View("Error"); // Veya başka bir alternatif view döndürebilirsiniz
            }

            return View(values);
        }

    }
}
