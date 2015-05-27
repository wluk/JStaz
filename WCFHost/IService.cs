using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;

namespace WCFHost
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IList<PersonDTO> GetAllPersons();

        [OperationContract]
        PersonDTO Get(int id);

        [OperationContract]
        void Add(PersonDTO p);


    }
}
