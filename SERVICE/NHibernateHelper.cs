using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MODEL.Model;
using NHibernate;
using NHibernate.Context;
using NHibernate.Exceptions;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
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
            try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(@"Server=.; Database=NHibernate_ex_3; Trusted_Connection=True;")
                    .ShowSql()
                )
                    .Mappings(m => m.FluentMappings
                        .AddFromAssemblyOf<Person>())
                            .BuildSessionFactory();
                //.Mappings(m => m.FluentMappings
                //    .AddFromAssemblyOf<Course>())
                //    .ExposeConfiguration(cfg => new SchemaExport(cfg)
                //        .Create(true, true))
                //        .BuildSessionFactory();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
