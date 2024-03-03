using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class NotificationService
    {
        public IEmailService _emailService;

        public NotificationService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        /// <summary>
        /// Method Injection
        /// </summary>
        /// <param name="emailService"></param>
        /// <param name="receipt"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public void SendNotification(string receipt, string body)
        {
            _emailService.SendMail(receipt,"Notification",body);
        }
    }
}
