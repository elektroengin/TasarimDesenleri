using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public interface IPayRepository
    {
        bool Payment(int productId, int orderId);
    }
}
