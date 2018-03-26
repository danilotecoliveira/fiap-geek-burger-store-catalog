using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Contract;
using GeekBurger.StoreCatalog.Core.Interfaces;

namespace GeekBurger.StoreCatalog.Controllers
{
    /// <summary>
    /// Products endpoints
    /// </summary>
    public class ProductController : Controller
    {
        private readonly IProductCore _productCore;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productCore"></param>
        public ProductController(IProductCore productCore)
        {
            _productCore = productCore;
        }

        /// <summary>
        /// Return all products for user with restrictions
        /// </summary>
        /// <param name="user">Object User with restrictions</param>
        /// <response code="200">Returned successfully</response>
        /// <response code="400">Returned bad request</response>
        [HttpGet]
        [Route("products/{user}")]
        public IActionResult GetProducts([FromBody] User user)
        {
            var result = new OperationResult<IEnumerable<Product>>();

            try
            {
                result.Data = _productCore.GetProductsFromUser(user);
                result.Success = true;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return BadRequest(result);
            }
        }
    }
}