using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Absract
{
    internal interface IContactDAL:IGenericDAL<Contact>
    {
    }
}
