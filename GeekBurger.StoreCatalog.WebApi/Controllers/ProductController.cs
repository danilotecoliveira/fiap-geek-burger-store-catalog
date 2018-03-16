using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;
using GeekBurger.StoreCatalog.Core;
using GeekBurger.StoreCatalog.Core.Interfaces;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    public class ProductController : Controller
    {
        private IProductCore _productCore;

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

                result.Data = _productCore.GetAllProductsAvaliables();
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