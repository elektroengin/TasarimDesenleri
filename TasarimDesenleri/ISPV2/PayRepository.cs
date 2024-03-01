using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public class PayRepository : IPayRepository
    {
        public bool Payment(int productId, int orderId)
        {
            Console.WriteLine("Payment");
            return true;
        }
    }
}
