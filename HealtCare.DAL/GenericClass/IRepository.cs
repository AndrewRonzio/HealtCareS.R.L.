using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtCare.DAL.GenericClass
{
    public interface IRepository<T> where T : class
    {
        T? Get(string id);

        List<T> GetAll();

        T Create(T entity);

    }
}
