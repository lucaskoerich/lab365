using BasicAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("clientes")]
    public class ClientesController : Controller
    {
        [HttpGet]
        public ActionResult Metodo([FromQuery] string nome)
        {
            return Ok($"Olá, {nome}!");
        }

        [HttpGet]
        [Route("{id}")]
        public string ObterClienteComId([FromQuery] string nome, [FromRoute] int id)
        {
            return $"Olá, {nome}! Seu ID é {id}.";
        }

        [HttpGet]
        [Route("id/{id}")]
        public ActionResult ObterCliente([FromQuery] string nome, [FromRoute] int id)
        {
            return Ok(new Cliente(id, nome));
        }
    }
}