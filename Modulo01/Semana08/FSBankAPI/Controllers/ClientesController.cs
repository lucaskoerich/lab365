using FSBankAPI.Interfaces;
using FSBankAPI.Models;
using FSBankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FSBankAPI.Controllers;

[Route("clientes")]
public class ClientesController : Controller
{
    private IClientesService _clienteService = new ClienteService();


    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_clienteService.ExibirClientes());
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult GetPorId([FromRoute] int id)
    {
        return Ok(_clienteService.BuscarCliente(id));
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
    public ActionResult PostPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica)
    {
        _clienteService.CriarConta(pessoaJuridica);
        return Created(Request.Path, pessoaJuridica);
    }

    [HttpPut]
    [Route("pessoafisica/{id}")]
    public ActionResult AtualizarPessoaFisica([FromBody] PessoaFisica pessoaFisica, int id)
    {
        _clienteService.AtualizarPessoaFisica(pessoaFisica, id);
        return Ok();
    }

    [HttpPut]
    [Route("pessoajuridica/{id}")]
    public ActionResult AtualizarPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica, int id)
    {
        _clienteService.AtualizarPessoaJuridica(pessoaJuridica, id);
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult DeletarCliente([FromRoute] int id)
    {
        Cliente clienteDeletar = _clienteService.BuscarCliente(id);

        if (clienteDeletar.Saldo != 0)
        {
            return BadRequest($"Não foi possível deletar cliente. Cliente há saldo de: {clienteDeletar.Saldo}");
        }


        _clienteService.DeletarCliente(id);
        return Ok();
    }
}