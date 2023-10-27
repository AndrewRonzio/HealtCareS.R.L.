using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtCare.DAL.Data;
using HealtCare.DAL.IRepository;
using HealtCare.DAL.GenericClass;

namespace HealtCare.DAL.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RetiDbContext ctx) : base(ctx)
        {
        }
    }
}
