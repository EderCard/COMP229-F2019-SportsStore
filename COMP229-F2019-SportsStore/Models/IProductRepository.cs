using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_SportsStore.Models
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
