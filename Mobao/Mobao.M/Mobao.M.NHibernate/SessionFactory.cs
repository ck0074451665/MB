using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate
{
    public class SessionFactory
    {
        public static ISessionFactory GetCurrentFactory()
        {
            if (sessionFactory == null)
            {
                sessionFactory = CreateSessionFactory();
            }
            return sessionFactory;
        }
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    FluentNHibernate.Cfg.Db.OracleDataClientConfiguration.Oracle10
                        .ConnectionString(s => s.Server("").Port(1521).Username("").Password("")
                )).BuildSessionFactory();
        }
        private static ISessionFactory sessionFactory
        {
            get;
            set;
        }
    }
}
