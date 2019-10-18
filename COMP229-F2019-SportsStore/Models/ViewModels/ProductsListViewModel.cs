using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP229_F2019_SportsStore.Models;

namespace COMP229_F2019_SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
