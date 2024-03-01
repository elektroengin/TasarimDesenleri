using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public interface IOderRepository
    {
        List<string> GetOrderList();
        int GetOrderId(int productId);
    }
}
