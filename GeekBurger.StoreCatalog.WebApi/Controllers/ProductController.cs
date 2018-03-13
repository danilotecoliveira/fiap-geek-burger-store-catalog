using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;
using System.Linq;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("products/{user}")]
        public IActionResult GetProducts(User user)
        {
            var result = new OperationResult<IEnumerable<Product>>();

            try
            {
                // verifica se o usuário tem restrição // get ingredients/{restrictions}/products

                // recebe um status code 200 com os resultados

                // filtra os produtos por restruições e áreas disponíveis

                // retorna os produtos

                var productsAvailable = LoadProducts();
                result.Data = productsAvailable.ToList().Where(m => m.StoreId == Guid.Parse("8048e9ec-80fe-4bad-bc2a-e4f4a75c834e"));

                result.Success = true;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;

                return BadRequest(result);
            }
        }

        private IEnumerable<Product> LoadProducts()
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