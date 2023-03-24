using FSBankAPI.Models;
using FSBankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FSBankAPI.Controllers;

[Route("clientes")]
public class ClientesController : Controller
{
    private ClienteService _clienteService = new();


    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_clienteService.ExibirClientes());
    }
    
    [HttpGet]
    [Route("{id}")]
    public ActionResult GetPorID([FromRoute] int id)
    {
       return Ok(_clienteService.ExibirClientesPorId(id));
    }
    
    
    [HttpPost]
    [Route("pessoaFisica")]
    public ActionResult PostPessoaFisica([FromBody] PessoaFisica pessoaFisica)
    {
        _clienteService.CriarConta(pessoaFisica);
        return Created(Request.Path, pessoaFisica);
    }
    
    
    [HttpPost]
    [Route("pessoaJuridica")]
    public ActionResult PostPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica )
    {
        _clienteService.CriarConta(pessoaJuridica);
        return Created(Request.Path, pessoaJuridica );
    }
    
    
}