using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DependencyInversion
{
    public class NotificationService
    {
        /// <summary>
        /// Property Injection
        /// </summary>
        public IEmailService EmailService { get; set; }

        public void SendNotification(string receipt, string body)
        {
            EmailService.SendMail(receipt,"Notification",body);
        }

        /// <summary>
        /// Method Injection
        /// </summary>
        /// <param name="emailService"></param>
        /// <param name="receipt"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public void SendNotification(IEmailService emailService, string receipt, string subject, string body)
        {
            emailService.SendMail(receipt,"Notification",body);
        }
    }
}
