using System.Net;
using Microsoft.AspNetCore.Mvc;
using AlcoholApi.Domain.Entities;

namespace AlcoholController.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        
        [HttpGet]
        [Route("Controller/{cantidad}/{bebida}/{peso}")]
        
        public IActionResult Obteneralcohol(int cantidad, string bebida,int peso)
        {
            
            var resultado = new Operacion();
            resultado.dato_1(cantidad,bebida);
            resultado.dato_2(peso);
            resultado.ReturnTotal();
            return Ok(resultado.ReturnTotal());
        }
    }
}