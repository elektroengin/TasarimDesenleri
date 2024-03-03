using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class EmailService : IEmailService
    {
        public void SendMail(string receipt, string subject, string body)
        {
            //mail.gmail.com adresine elektroengin@gmail.com mail gönderilecek....
            Console.WriteLine(receipt + ' ' + subject + ' ' + body);
        }
    }
}
