using System.Net.Http;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IRequestApi
    {
        HttpResponseMessage GetStatusProductionAreas();

        HttpResponseMessage GetProductionAreas();

        HttpResponseMessage GetStatusProducts();

        HttpResponseMessage GetProducts(string restrictions);
    }
}
