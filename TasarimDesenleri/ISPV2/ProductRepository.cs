using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public class ProductRepository : IProductRepository
    {
        public List<string> GetProducList()
        {
            Console.WriteLine("Product List");
            return new List<string>();
        }

        public int GetProductId(int productId)
        {
            Console.WriteLine("Product");
            return 1;
        }

        public int GetProductCount()
        {
            Console.WriteLine("Order List");
            return 100;
        }

        public int GetProductCount(DateTime startDateTime, DateTime enDateTime)
        {
            Console.WriteLine("GetProductCount");
            return 15;
        }
    }
}
