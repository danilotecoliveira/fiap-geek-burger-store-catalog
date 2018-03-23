using System;
using System.Linq;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Contract;
using GeekBurger.StoreCatalog.Core.Interfaces;
using GeekBurger.StoreCatalog.Infra.Interfaces;
using Newtonsoft.Json;

namespace GeekBurger.StoreCatalog.Core
{
    public class ProductCore : IProductCore
    {
        private readonly IRequestApi _requestApi;
        private readonly IRepository<ProductionArea> _repository;

        public ProductCore(IRequestApi requestApi, IRepository<ProductionArea> repository)
        {
            _requestApi = requestApi;
            _repository = repository;
        }

        public List<Product> GetProductsFromUser(User user)
        {
            var restrictions = String.Join(",", user.Restrictions);
            var responseProducts = _requestApi.GetProducts(restrictions);

            if(responseProducts.IsSuccessStatusCode)
            {
                var jsonProduct = responseProducts.Content.ReadAsStringAsync().Result;
                var products = JsonConvert.DeserializeObject<List<Product>>(jsonProduct);

                var productionAreas = _repository.GetAll();
                //var result = productionAreas.Where(x => user.Restrictions.ToList().Contains(x.Restrictions)).ToList();
            }
            throw new Exception("");
        }
    }
}
