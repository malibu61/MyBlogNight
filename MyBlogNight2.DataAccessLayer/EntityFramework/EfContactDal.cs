using MyBlogNight2.DataAccessLayer.Abstract;
using MyBlogNight2.DataAccessLayer.Context;
using MyBlogNight2.DataAccessLayer.Repositories;
using MyBlogNight2.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight2.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(BlogContext context) : base(context)
        {
        }
    }
}
