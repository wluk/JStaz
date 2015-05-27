using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;

namespace WCFHost
{
    public class Service : IService
    {
        CRUD crud = new CRUD();

        public IList<WcfService.PersonDTO> GetAllPersons()
        {
            return crud.SelectAll().ToArray();
        }

        public WcfService.PersonDTO Get(int id)
        {
            return crud.SelectById(id);
        }

        public void Add(WcfService.PersonDTO p)
        {
            crud.Create(p);
        }
    }
}
