using GeekBurger.StoreCatalog.Contract;
using GeekBurger.StoreCatalog.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Infra.Repositories
{
    public class Products : IProducts
    {
        public IEnumerable<Product> GetAll()
        {
            var losAngelesStore = new Guid("8048e9ec-80fe-4bad-bc2a-e4f4a75c834e"); // store
            var beverlyHillsStore = new Guid("8d618778-85d7-411e-878b-846a8eef30c0"); // store

            var beef = new Item { ItemId = Guid.NewGuid(), Name = "beef" };
            var mustard = new Item { ItemId = Guid.NewGuid(), Name = "mustard" };
            var bread = new Item { ItemId = Guid.NewGuid(), Name = "bread" };

            var productsAvailable = new List<Product>();

            productsAvailable.Add(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Darth Bacon",
                Image = "hamb1.png",
                StoreId = losAngelesStore,
                Items = new List<Item>
                {
                    beef,
                    new Item { ItemId = Guid.NewGuid(), Name = "ketchup" },
                    bread
                }
            });

            productsAvailable.Add(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Cap. Spork",
                Image = "hamb2.png",
                StoreId = losAngelesStore,
                Items = new List<Item>
                {
                    new Item { ItemId = Guid.NewGuid(), Name = "pork"},
                    mustard,
                    new Item { ItemId = Guid.NewGuid(), Name = "whole bread" }
                }
            });

            productsAvailable.Add(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Beef Turner",
                Image = "hamb3.png",
                StoreId = beverlyHillsStore,
                Items = new List<Item>
                {
                    beef,
                    mustard,
                    bread
                }
            });

            return productsAvailable;
        }
    }
}
