using SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFWebService
{
    [ServiceContract]
    public interface IWCFWebService
    {
        [OperationContract]
        string Msg();

        [OperationContract]
        List<PersonDTO> PersonList();
    }
}
