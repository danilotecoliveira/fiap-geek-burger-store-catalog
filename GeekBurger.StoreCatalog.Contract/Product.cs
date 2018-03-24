using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeekBurger.StoreCatalog.Contract
{
    public class Product
    {
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Item> Items { get; set; }

        public static IEnumerable<Product> GetProducts(string json)
        {
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
