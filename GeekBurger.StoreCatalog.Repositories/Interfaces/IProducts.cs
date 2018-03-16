using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> GetAll();
    }
}
