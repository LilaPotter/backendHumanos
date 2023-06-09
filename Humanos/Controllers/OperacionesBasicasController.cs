using Microsoft.AspNetCore.Mvc;

namespace Humanos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        // GET: api/Operaciones/Suma/5/3
        [HttpGet("Suma/{a}/{b}")]
        public IActionResult Suma(int a, int b)
        {
            int resultado = a + b;
            return Ok(resultado);
        }

        // GET: api/Operaciones/Resta/5/3
        [HttpGet("Resta/{a}/{b}")]
        public IActionResult Resta(int a, int b)
        {
            int resultado = a - b;
            return Ok(resultado);
        }

        // GET: api/Operaciones/Multiplicacion/5/3
        [HttpGet("Multiplicacion/{a}/{b}")]
        public IActionResult Multiplicacion(int a, int b)
        {
            int resultado = a * b;
            return Ok(resultado);
        }

        // GET: api/Operaciones/Division/6/2
        [HttpGet("Division/{a}/{b}")]
        public IActionResult Division(int a, int b)
        {
            if (b == 0)
            {
                return BadRequest("No se puede dividir entre cero.");
            }

            double resultado = (double)a / b;
            return Ok(resultado);
        }
    }
}
