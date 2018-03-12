using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetProducts/{idUser:long}")]
        public IActionResult GetProducts(long idUser)
        {
            var result = new OperationResult<List<Product>>();
            try
            {
                var losAngelesStore = new Guid("8048e9ec-80fe-4bad-bc2a-e4f4a75c834e");
                var beverlyHillsStore = new Guid("8d618778-85d7-411e-878b-846a8eef30c0");
                var beef = new Item { ItemId = Guid.NewGuid(), Name = "beef" };
                var mustard = new Item { ItemId = Guid.NewGuid(), Name = "mustard" };
                var bread = new Item { ItemId = Guid.NewGuid(), Name = "bread" };
                result.Data = new List<Product>()
                 {
                    new Product
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
                    },
                    new Product
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
                    },
                    new Product
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
                    }
                 };

                result.Success = true;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;

                return BadRequest(result);
            }
        }
    }
}