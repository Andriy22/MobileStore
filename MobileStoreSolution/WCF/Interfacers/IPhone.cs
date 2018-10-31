using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCF
{
    [ServiceContract]
    public interface IPhone
    {
        [OperationContract]
        List<PhoneDTO> GetAllPhone();
    }
}
