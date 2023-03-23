using BasicAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("clientes")]
    public class ClientesController : Controller
    {
        static List<Cliente> _clientes = new();

        [HttpGet]
        public ActionResult Metodo([FromQuery] string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return Ok(_clientes);
            }

            var filtroClientes = _clientes.Where(x => x.Nome == nome);
            return Ok(filtroClientes);
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

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _clientes.Add(cliente);
            return Created(Request.Path, cliente);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var cliente = _clientes.Find(x => x.Id == id);

            _clientes.Remove(cliente);
            return Ok();
        }
    }
}