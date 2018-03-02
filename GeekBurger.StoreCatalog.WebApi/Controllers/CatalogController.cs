using System;
using Microsoft.AspNetCore.Mvc;
using GeekBurger.StoreCatalog.Entities;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        /// <summary>
        /// Description
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetCatalogs(string id)
        {
            var result = new OperationResult<object>();

            try
            {
                result.Data = new { id = Guid.Parse(id).ToString() };
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
