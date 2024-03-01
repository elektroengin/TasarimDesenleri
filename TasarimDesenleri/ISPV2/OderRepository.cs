using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public class OderRepository
    {
        public List<string> GetOrderList()
        {
            Console.WriteLine("Order List");
            return new List<string>();
        }

        public int GetOrderId(int productId)
        {
            Console.WriteLine("Order Id");
            return 2;
        }
    }
}
