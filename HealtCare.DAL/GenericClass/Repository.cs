using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HealtCare.DAL.Data;
using Microsoft.Identity.Client;

namespace HealtCare.DAL.GenericClass
{
    public class Repository<T> : IRepository<T> where T : class 
    {

        protected readonly RetiDbContext _ctx;

        public Repository(RetiDbContext ctx)
        {
            _ctx = ctx;
        }


        public T? Get(string id)
        {
            return _ctx.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

    }
}
