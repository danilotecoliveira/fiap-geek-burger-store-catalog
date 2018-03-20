using System;
using System.Net.Http;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IRequestApi
    {
        // GET : production/areas return 200 areas
        HttpResponseMessage GetAreas();
        // GET : products/{storeId} return 200 products
        HttpResponseMessage GetProducts(string restrictions);
    }
}
