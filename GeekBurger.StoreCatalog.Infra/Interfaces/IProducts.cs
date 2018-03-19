using System.Collections.Generic;
using GeekBurger.StoreCatalog.Contract;
using System;
using System.Text;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> GetAll();
    }
}
