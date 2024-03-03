using _5.DependencyInversion;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Constructor
            /// Method
            /// Property
            /// </summary>
            /// <param name="args"></param>
            var emailService = new EmailService();
            var notificationService = new NotificationService();
            notificationService.SendNotification(emailService,"deneme","Notification","test");


        }
    }
}