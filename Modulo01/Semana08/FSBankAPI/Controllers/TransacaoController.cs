using FSBankAPI.Interfaces;
using FSBankAPI.Models;
using FSBankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FSBankAPI.Controllers;

[Route("transacao")]
public class TransacaoController : Controller
{
    private IClientesService _clienteService = new ClienteService();
    private Transacao _transacao = new();

    [HttpPost]
    [Route("{idCliente}")]
    public ActionResult AdicionarTransacao([FromBody] Transacao transacao, [FromRoute] int idCliente)
    {
        _clienteService.AdicionarTransacao(transacao, idCliente);
        return Created(Request.Path, transacao);
    }

    [HttpGet]
    [Route("{idCliente}")]
    public ActionResult ListarTransacao([FromRoute] int idCliente)
    {
        return Ok(_clienteService.ListarTransacao(idCliente));
    }
}