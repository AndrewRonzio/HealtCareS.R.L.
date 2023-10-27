using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtCare.DAL.Data;
using HealtCare.DAL.GenericClass;

namespace HealtCare.DAL.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
