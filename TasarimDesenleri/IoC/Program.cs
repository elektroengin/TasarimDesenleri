using Ninject;
using System.ComponentModel;
using System.Reflection;
using Microsoft.Extensions.Hosting;
using Unity;
using Microsoft.Extensions.DependencyInjection;
using System;
using Castle.Windsor;
using StructureMap;
using Castle.MicroKernel.Registration;

namespace IoC
{
    internal class Program
    {
        /// <summary>
        ///Mülkatlarda sıkça sorulardan bir tanesi olan IoC Container nedir?
        ///Hiç IoC Container kullandın mı?
        ///Kullandıysan hangilerini kullanıdız?
        /// 
        /// IoC (Inversion Of Control)
        /// Uygulamamızın yaşam döngüsü boyunca birbirine bağımlılığı az olan nesneler oluşturmnayı amaçlayan
        /// yazılım geliştirme prnsibidir. Nesnelerin yaşam döngüsünden sorumludur ve yönetimini sağlar.
        ///
        ///Ninject,Unity,Structure Map,Castle Windsor,AutoFac,Microsoft Extentions Dependency Injection (Nuget paketidir)
        ///
        ///Avantajları:
        ///Bağımlılığı az olan (loosely coupled) sınıfır oluşturmak
        ///Kolay Unit Test yazılır
        ///Yönetebilirlik
        ///Modelüler yapılar , Microservice yapıları oluşturmak
        ///Farklı implementasyonlara geçiş yapılabilir. 
        ///
        ///
        ///Transit(AddTransit)     : Obje oluşturduğumuzda yeni bir instance olarak verilir.
        ///Scoped(AddScoped)       : Yeni bir istek geldiğinde yeni bir obje oluşturur.
        ///Singleton(AddSingleton) : ilk istek geldiğinde bir tane instance oluşturulur, sorasında gelen tüm
        ///isteklerde aynı instance kullanılır. 
        ///
        ///  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //var emailService = new EmailService();
            //var notificationService = new NotificationService();
            //notificationService.SendNotification(emailService, "deneme", "Notification", "test");

            //var container = new UnityContainer();
            //container.RegisterType<IEmailService, EmailService>();
            //var notificationService = container.Resolve<NotificationService>();

            //var kernel = new StandardKernel();
            //kernel.Bind<IEmailService>().To<EmailService>();
            //var notificationServiceNinject = kernel.Get<NotificationService>();
            //notificationServiceNinject.SendNotification("deneme","test");

            //IServiceProvider BuildServices() => new ServiceCollection()
            //    .AddScoped<IEmailService, EmailService>()
            //   .BuildServiceProvider();
            //var serviceProvider2 = BuildServices().GetService<IEmailService>();
            //serviceProvider2.SendMail("deneme", "Notification", "test");

            //var container = new StructureMap.Container();
            //var sauce = container.GetInstance<EmailService>();
            //sauce.SendMail("deneme", "Notification", "test");

            //var container = new WindsorContainer();
            //container.Register(Castle.MicroKernel.Registration.Component.For<IEmailService>().ImplementedBy<EmailService>());
            //var root = container.Resolve<IEmailService>();
            //root.SendMail("deneme", "Notification", "test");
        }
    }
}