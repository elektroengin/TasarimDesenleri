using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidV2
{
    public  class QueryRepository
    {
        public void Query(Invoice invoice)
        {
            //Invoice Dataları veritabanından sorgulanacak
            Console.WriteLine("Faytura Kaydedildi {0} : ", invoice.FaturaNo);
        }
    }
}
