using Microsoft.AspNetCore.Mvc;
using System;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        /// <summary>
        /// Register a new user on application
        /// </summary>
        /// <param name="user">New user to register</param>
        /// <remarks>Adds new user to application and grant access</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{id}")]
        public IActionResult GetCatalogs(Guid id)
        {
            return Ok();
        }
    }
}
