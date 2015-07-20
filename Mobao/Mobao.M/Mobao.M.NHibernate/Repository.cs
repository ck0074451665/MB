
using Mobao.M.Data;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate
{
    public class Repository<T> : IRepository<T> where T : class,new()
    {

        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
