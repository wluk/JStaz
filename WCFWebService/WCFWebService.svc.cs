using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NHibernate.Linq;
using SERVICE;
using MODEL.Model;

namespace WCFWebService
{
    public class WCFWebService : IWCFWebService
    {
        private CRUD _crud;

        public WCFWebService()
        {
            
        }

        public string Msg()
        {
            return "Hello, was is das WCF?";
        }

        public List<SERVICE.PersonDTO> PersonList()
        {
            _crud = new CRUD();
            SeedData.SeedDataStart();

            return _crud.SelectAll();
        }
    }
}
