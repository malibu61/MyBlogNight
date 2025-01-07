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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            return _appUserDal.GetById(id);
        }

        public void TInsert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
