using System;
using Microsoft.AspNetCore.Mvc;
using GeekBurger.StoreCatalog.Contract;
using GeekBurger.StoreCatalog.Core.Interfaces;

namespace GeekBurger.StoreCatalog.Controllers
{
    /// <summary>
    /// Store Catalog endpoints
    /// </summary>
    public class StoreCatalogController : Controller
    {
        private IStoreCatalogCore _storeCatalogCore;

        public StoreCatalogController(IStoreCatalogCore storeCatalogCore)
        {
            _storeCatalogCore = storeCatalogCore;
        }

        /// <summary>
        /// Return store catalog by Guid identifier
        /// </summary>
        /// <param name="storeid">Guid of store catalog</param>
        /// <returns></returns>
        [HttpGet("store/{storeid:Guid}")]
        public IActionResult GetStore(Guid storeid)
        {
            var result = new OperationResult<bool>();

            try
            {
                result.Data = _storeCatalogCore.StatusServers();

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return StatusCode(503, result);
            }
        }
    }
}