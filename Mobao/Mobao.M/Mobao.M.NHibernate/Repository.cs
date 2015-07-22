
using Mobao.M.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate.Linq.Expressions;

namespace Mobao.M.NHibernate
{
    public class Repository<T> : IRepository<T> where T : class,new()
    {
        protected ISessionFactory _sessionFactory;

        public Repository()
        {
            _sessionFactory = FluentNHibernateHelper.GetSessionFactory();
        }

        public void Add(T t)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                session.Save(t);
                session.Flush();
            }
        }

        public IQueryable<T> GetAll()
        {
            ISession session = _sessionFactory.OpenSession();
            return session.Query<T>();
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
