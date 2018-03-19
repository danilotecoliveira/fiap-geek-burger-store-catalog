using System.Collections.Generic;
using GeekBurger.StoreCatalog.Contract;

namespace GeekBurger.StoreCatalog.Core.Interfaces
{
    public interface IProductCore
    {
        IEnumerable<Product> GetAllProductsAvaliables();
    }
}