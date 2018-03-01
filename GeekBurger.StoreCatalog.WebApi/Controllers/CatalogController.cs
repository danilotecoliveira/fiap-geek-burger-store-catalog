using Microsoft.AspNetCore.Mvc;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        [HttpGet("{catalogs}")]
        public IActionResult GetCatalogs()
        {
            return Ok();
        }
    }
}
