using MyBlogNight2.BusinessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.BusinessLayer.Concrete
{
    public class NewsletterSubscriberManager : INewsletterSubscriberService
    {

        private readonly INewsletterSubscriberDal _newsletterSubscriberDal;

        public NewsletterSubscriberManager(INewsletterSubscriberDal newsletterSubscriberDal)
        {
            _newsletterSubscriberDal = newsletterSubscriberDal;
        }

        public void TDelete(int id)
        {
            _newsletterSubscriberDal.Delete(id);
        }

        public List<NewsletterSubscriber> TGetAll()
        {
            return _newsletterSubscriberDal.GetAll();
        }

        public NewsletterSubscriber TGetById(int id)
        {
            return _newsletterSubscriberDal.GetById(id);
        }

        public void TInsert(NewsletterSubscriber entity)
        {
            _newsletterSubscriberDal.Insert(entity);
        }

        public void TUpdate(NewsletterSubscriber entity)
        {
            _newsletterSubscriberDal.Update(entity);
        }
    }
}
