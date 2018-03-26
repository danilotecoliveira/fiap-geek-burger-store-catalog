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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="storeCatalogCore"></param>
        public StoreCatalogController(IStoreCatalogCore storeCatalogCore)
        {
            _storeCatalogCore = storeCatalogCore;
        }

        /// <summary>
        /// Check if dependence services are available
        /// </summary>
        /// <response code="200">Returned successfully</response>
        /// <response code="500">Returned services not available</response>
        /// <response code="503">Returned internal server error</response>
        [HttpGet("statusServer/")]
        public IActionResult GetStatusServer()
        {
            var result = new OperationResult<bool>();

            try
            {
                var response = _storeCatalogCore.StatusServers();

                if (response)
                {
                    result.Success = true;
                    result.Data = true;
                    return Ok(result);
                }                    
                else
                {
                    result.Success = true;
                    result.Data = false;
                    result.Message = "Services not available";
                    return StatusCode(503, result);
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return StatusCode(500, result);
            }
        }
    }
}