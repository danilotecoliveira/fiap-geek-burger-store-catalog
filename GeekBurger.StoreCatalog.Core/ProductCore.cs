using System;
using System.Linq;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Contract;
using GeekBurger.StoreCatalog.Core.Interfaces;
using GeekBurger.StoreCatalog.Infra.Interfaces;

namespace GeekBurger.StoreCatalog.Core
{
    public class ProductCore : IProductCore
    {
        private IProducts _products;

        public ProductCore(IProducts products)
        {
            _products = products;
        }

        public IEnumerable<Product> GetAllProductsAvaliables()
        {
            var products = _products.GetAll();
            return products.ToList().Where(m => m.StoreId == Guid.Parse("8048e9ec-80fe-4bad-bc2a-e4f4a75c834e"));
        }
    }
}
