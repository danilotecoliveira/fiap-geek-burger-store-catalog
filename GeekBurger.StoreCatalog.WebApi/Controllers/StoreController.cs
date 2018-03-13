using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GeekBurger.StoreCatalog.Entities;
using GeekBurger.StoreCatalog.Entities.Singletons;

namespace GeekBurger.StoreCatalog.WebApi.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet("store/{storeid}")]
        public IActionResult GetStore(Guid storeid)
        {
            var result = new OperationResult<bool>();

            try
            {
                // verifica se os outros serviços estão ok

                // retorna se está on line

                result.Data = true;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return StatusCode(503, result);
            }
        }

        public static List<Area> GetAreas()
        {
            Areas.Instance.Add(new Area { AreaId = Guid.NewGuid(), Name = "Franch Fries" });
            Areas.Instance.Add(new Area { AreaId = Guid.NewGuid(), Name = "Burguers" });
            Areas.Instance.Add(new Area { AreaId = Guid.NewGuid(), Name = "Drinks" });
            Areas.Instance.Add(new Area { AreaId = Guid.NewGuid(), Name = "Ice Creams" });

            // Areas.Instance // retorno da api que devolve as áreas disponíveis
            return Areas.Instance;
        }
    }
}