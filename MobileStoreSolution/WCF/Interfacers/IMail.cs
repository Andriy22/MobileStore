using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCF
{
    [ServiceContract]
    public interface IMail
    {
        [OperationContract]
        void SendOnEmail(string subject, string Messege, UserDTO user);
    }
}
