using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product{Name="Footbal", Price = 25},
            new Product{Name="Surf borad", Price = 179},
            new Product{Name="Running shoes", Price = 95}
        }.AsQueryable<Product>();
    }
}
