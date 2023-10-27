using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtCare.DAL.Data;
using HealtCare.DAL.IRepository;
using HealtCare.DAL.Repository;

namespace HealtCare.DAL.GenericClass
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly RetiDbContext _ctx;

        public IUserRepository UserRepository { get; private set; }


        public UnitOfWork(RetiDbContext ctx)
        {
            _ctx = ctx;
            UserRepository = new UserRepository(ctx);
        }

        public bool Commit()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
