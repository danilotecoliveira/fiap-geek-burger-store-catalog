using GeekBurger.StoreCatalog.Infra.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GeekBurger.StoreCatalog.Infra.Services
{
    public class RequestApi : IRequestApi
    {
        public HttpResponseMessage GetAreas()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client.GetAsync("").Result;
            }
        }

        public HttpResponseMessage GetProducts(string restrictions)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://geekburger-ingredients.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client.GetAsync("ingredients/products/" + restrictions).Result;
            }
        }
    }
}
