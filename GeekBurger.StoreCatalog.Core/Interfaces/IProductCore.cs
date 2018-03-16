using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;

namespace GeekBurger.StoreCatalog.Core.Interfaces
{
    public interface IProductCore
    {
        IEnumerable<Product> GetAllProductsAvaliables();
    }
}
