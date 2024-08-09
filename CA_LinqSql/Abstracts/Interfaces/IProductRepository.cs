using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_LinqSql.Abstracts.Interfaces
{
    internal interface IProductRepository
    {
        void GetAvgProductPrice();
        void GetStockCategorySum();
    }
}
