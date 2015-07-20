using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
namespace Mobao.M.NHibernate
{
    /// <summary>
    /// Nhibernate辅助类
    /// </summary>
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISession _session;
        private static object _objLock = new object();
        private FluentNHibernateHelper()
        {

        }
        /// <summary>
        /// 创建ISessionFactory
        /// </summary>
        /// <returns></returns>
        /////  c.Server(".")
        //              .Password("sa")
        //              .Username("sa")
        //              .Database("Shop")
        //              .TrustedConnection()

        //          //数据库配置
        //.Database(
        //          //方言
        //FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2012
        //          //连接字符串
        //.ConnectionString(
        //     c => c.FromConnectionStringWithKey("")
        //    )cfg.Configure(AppDomain.CurrentDomain.BaseDirectory + "hibernate.cfg.xml")
        //          //是否显示sql
        //    .ShowSql()  cfg.Configure(AppDomain.CurrentDomain.BaseDirectory + "hibernate.cfg.xml")
        //    )c => c.Server("TESTHLS").Username("ts_doc").Password("mobaohls")FluentNHibernate.Cfg.Db.OracleClientConfiguration.Oracle10.ConnectionString("MOBAOHLS")
        //.Database(FluentNHibernate.Cfg.Db.OracleClientConfiguration.Oracle10.ConnectionString("MOBAOHLS"))
        public static ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
            {
                lock (_objLock)
                {
                    if (_sessionFactory == null)
                    {
                        var cfg = new Configuration();
                        //配置ISessionFactory
                        _sessionFactory = Fluently
                            .Configure(cfg.Configure(AppDomain.CurrentDomain.BaseDirectory + "hibernate.cfg.xml"))
                            //映射程序集
                      .Mappings(m => m.FluentMappings
                          .AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly())
                          .ExportTo("c:\\"))
                      .BuildSessionFactory();

                    }
                }
            }
            return _sessionFactory;

        }
        /// <summary>
        /// 重置Session
        /// </summary>
        /// <returns></returns>
        public static ISession ResetSession()
        {
            if (_session.IsOpen)
                _session.Close();
            _session = _sessionFactory.OpenSession();
            return _session;
        }
        /// <summary>
        /// 打开ISession
        /// </summary>
        /// <returns></returns>
        public static ISession GetSession()
        {
            GetSessionFactory();
            if (_session == null)
            {
                lock (_objLock)
                {
                    if (_session == null)
                    {
                        _session = _sessionFactory.OpenSession();
                    }
                }
            }
            return _session;
        }

    }
}