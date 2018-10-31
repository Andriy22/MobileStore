using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class OrderService : IPhone, IUser
    {
        public List<PhoneDTO> GetAllPhone()
        {
            List<PhoneDTO> Phones = new List<PhoneDTO>();
            Phones.Add(new PhoneDTO() { Name = "IPHONE", Description = "7", Price = 800 });
            return Phones;
        }

        bool IUser.Aut(string Email)
        {
            List<UserDTO> Users = new List<UserDTO>();
            Users.Add(new UserDTO() { Name = "Vasuan", Email = "istep.andriy@gmail.com" });
            foreach (var el in Users)
                if (el.Email == Email)
                    return true;
            return false;  
        }

        void IUser.MakeOrder(PhoneDTO Phone, UserDTO user)
        {
            List<OrderDTO> Order = new List<OrderDTO>();
            Order.Add(new OrderDTO() { Date = DateTime.Now, Phone = Phone, User = user });
        }
    }
}
