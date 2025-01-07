using Microsoft.Extensions.DependencyInjection;
using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.BusinessLayer.Concrete;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {

            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<INewsletterSubscriberDal, EfNewsletterSubscriberDal>();
            services.AddScoped<INewsletterSubscriberService, NewsletterSubscriberManager>();

            services.AddScoped<IAppUserDal, EfAppUserId>();
            services.AddScoped<IAppUserService, AppUserManager>();
        }
    }
}
