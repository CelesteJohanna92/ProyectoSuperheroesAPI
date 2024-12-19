using Microsoft.AspNetCore.Mvc;
using SuperheroesAPI.Factories;
using SuperheroesAPI.Request;
using SuperheroesAPI.Singletons;

namespace SuperheroesAPI.Controllers
{
    [ApiController]
    [Route("api/superheroes")]
    public class SuperheroesController : ControllerBase
    {
        [HttpPost("crear")]
        public IActionResult CrearSuperheroe([FromBody] CrearSuperheroeRequest request)
        {
            var superheroe = SuperheroeFactory.CrearSuperheroe(request.Tipo, request.Nombre);
            if (superheroe == null)
            {
                return BadRequest("Tipo de superhéroe no válido.");
            }
            return Ok(superheroe);
        }

        [HttpPost("visitarEnfermeria")]
        public IActionResult VisitarEnfermeria([FromBody] VisitarEnfermeriaRequest request)
        {
            var enfermeria = Enfermeria.Instancia;
            var saludActual = request.SaludActual;

            for (int i = 0; i < request.Veces; i++)
            {
                if (saludActual >= 5 || !enfermeria.AtenderVisita())
                {
                    break; // Salimos si alcanzamos el límite
                }
                saludActual++;
            }

            return Ok($"Salud actual del superhéroe: {saludActual}");
        }
    }
}