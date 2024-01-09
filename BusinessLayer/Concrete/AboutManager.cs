using BusinessLayer.Abstract;
using DataAccessLayer.Absract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        // biz burada dependency injection kullanacığız. peki neden ? 
        // Gelen entity nin reposuna ulaşmam lazım. 

        IAboutDAL _aboutDAl;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAl = aboutDAL;
        }
        public About GetById(int id)
        {
            var val= _aboutDAl.GetList().FirstOrDefault(x => x.AboutID == id);
            return val;
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
