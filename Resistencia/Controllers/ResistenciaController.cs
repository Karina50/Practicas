namespace Name.Controllers

{
    using System;
    using Resistencia.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        [HttpGet]
        [Route("Calcular/{Banda1}/{Banda2}/{Banda3}/{Banda4}")]
        public IActionResult Getop(string Banda1,string Banda2,string Banda3,string Banda4)
        {
            var resultado = new Resultado();
            resultado.banda_1(Banda1);
            resultado.banda_2(Banda2);
            resultado.banda_3(Banda3);
            resultado.banda_oro(Banda4);
            resultado.Returnoperacion();
            return Ok(resultado.Returnoperacion());
        }
    }
}