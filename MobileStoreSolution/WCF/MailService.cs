using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class MailService : IMail
    {
        SmtpClient smtpClient;
        MailMessage messege;
        public void SendOnEmail(string subject, string Messege, UserDTO user)
        {
 
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(@"PhoneStoreTestEmail1@gmail.com", "27082000ABB");

            MailAddress mailAddress = new MailAddress(@"PhoneStoreTestEmail1@gmail.com");
            messege = new MailMessage();
            messege.From = mailAddress;
            messege.To.Add(user.Email);
            messege.Subject = subject;
            messege.Body = Messege;
            smtpClient.EnableSsl = true;
            smtpClient.Send(messege);
        }
    }
}
