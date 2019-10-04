using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            this.context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
