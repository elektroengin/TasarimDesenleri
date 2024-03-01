using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPV2
{
    public interface IProductRepository
    {
        List<string> GetProducList();
        int GetProductId(int productId);

        int GetProductCount();

        int GetProductCount(DateTime startDateTime, DateTime enDateTime);
    }
}
