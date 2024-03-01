using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV1Hatali
{
    public class Repository : IRepository
    {
        public List<string> GetUserList()
        {
            Console.WriteLine("User List");
            return new List<string>();
        }

        public int GetUserId(string Username)
        {
            Console.WriteLine("User");
            return 0;
        }

        public List<int> GetUserRoles(string Username)
        {
            Console.WriteLine("User Roles");
            return new List<int>();
        }

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

        public bool Payment(int productId, int orderId)
        {
            Console.WriteLine("Payment");
            return true;
        }
    }
}
