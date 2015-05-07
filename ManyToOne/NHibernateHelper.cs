using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            //try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(@"Server=.; Database=ManyToOne; Trusted_Connection=True;")
                    .ShowSql()
               )
               .Mappings(m =>
                   m.FluentMappings
                    .AddFromAssemblyOf<Program>())
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
               .BuildSessionFactory();
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}