using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV1Hatali
{
    public interface IRepository
    {
        List<string> GetUserList();
        int GetUserId(string Username);
        List<int> GetUserRoles(string Username);

        List<string> GetProducList();
        int GetProductId(int productId);

        int GetProductCount();

        List<string> GetOrderList();
        int GetOrderId(int productId);

        bool Payment(int productId,int orderId);

    }
}
