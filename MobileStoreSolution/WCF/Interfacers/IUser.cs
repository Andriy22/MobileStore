using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCF
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        void MakeOrder(PhoneDTO Phone, UserDTO user);
        [OperationContract]
        bool Aut(string Email);
    }
}
