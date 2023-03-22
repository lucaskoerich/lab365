using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("[controller]")]
    public class VeiculosController : Controller
    {
        static List<string> carros = new() { { "Gol" }, { "Argo" }, { "Nivus" } };

        [HttpGet]
        public ActionResult GetCarros([FromQuery] string carro)
        {
            if (string.IsNullOrEmpty(carro))
            {
                return Ok(carros);
            }

            if (carros.Exists(x => x == carro))
            {
                return Ok("Carro cadastrado!");
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        public ActionResult PostCarros([FromQuery] string carro)
        {
            carros.Add(carro);
            return Ok(carros);
        }

        [HttpDelete]
        public ActionResult DeleteCarros([FromQuery] string carro)
        {
            carros.Remove(carro);
            return Ok();
        }
    }
}