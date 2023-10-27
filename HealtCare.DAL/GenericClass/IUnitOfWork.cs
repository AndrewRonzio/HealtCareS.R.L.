using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtCare.DAL.IRepository;

namespace HealtCare.DAL.GenericClass
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        bool Commit();
    }
}
