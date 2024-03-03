using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    /// <summary>
    /// Method Injection
    /// </summary>
    public interface IEmailService
    {
        void SendMail(string receipt, string subject, string body);
    }
}
