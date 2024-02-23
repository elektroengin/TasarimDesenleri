using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidV2
{
    public class CommandRepository
    {
        public static int CommandInvoice(Invoice invoice)
        {
            //Veritabana Güncelleme,Silme ve Delete
            Console.WriteLine("Günceleme yapıldı {0} : ", invoice.FaturaNo);
            return 1;
        }
    }
}
