using Exercicio_Semana.DTOS;
using Exercicio_Semana.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_Semana.Controllers;

[Route("[controller]")]
[ApiController]
public class MarcaController : Controller
{
    private readonly LocacaoContext _locacaoContext;

    public MarcaController(LocacaoContext locacaoContext)
    {
        _locacaoContext = locacaoContext;
    }

    [HttpPost]
    public ActionResult Post([FromBody] MarcaDto marcaDto)
    {
        MarcaModel marcaModel = new();

        marcaModel.Nome = marcaDto.Nome;

        _locacaoContext.Add(marcaModel);
        _locacaoContext.SaveChanges();

        return Ok("Marca salva com sucesso!");
    }

    [HttpPut]
    public ActionResult Put([FromBody] MarcaDto marcaDto)
    {
        MarcaModel marcaModel = _locacaoContext.Marca.Find(marcaDto.Codigo);

        if (marcaModel != null)
        {
            marcaModel.Nome = marcaDto.Nome;

            _locacaoContext.Attach(marcaModel);
            _locacaoContext.SaveChanges();
            return Ok("Marca alterada com sucesso!");
        }

        return BadRequest("Marca não encontrada!");
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete([FromRoute] int id)
    {
        MarcaModel marcaModel = _locacaoContext.Marca.Find(id);

        if (marcaModel != null)
        {
            _locacaoContext.Remove(marcaModel);
            _locacaoContext.SaveChanges();
            return Ok("Marca removida com sucesso!");
        }

        return BadRequest("Marca não encontrada!");
    }

    [HttpGet]
    public ActionResult<List<MarcaDto>> GetTodas()
    {
        // todos os registros de Marca que se encontram na _locacaoContext.Marca
        var listaMarcaModel = _locacaoContext.Marca;

        // onde vai armazenar os registros para retornar em forma de lista
        List<MarcaDto> listaMarcaDtos = new();

        foreach (var item in listaMarcaModel)
        {
            MarcaDto marcaDto = new();

            marcaDto.Nome = item.Nome;
            marcaDto.Codigo = item.Id;

            listaMarcaDtos.Add(marcaDto);
        }

        return Ok(listaMarcaDtos);
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult GetPorId([FromRoute] int id)
    {
        var marcaModel = _locacaoContext.Marca.Find(id);
        MarcaDto marcaDto = new();

        if (marcaModel == null)
        {
            return BadRequest("Marca não encontrada!");
        }

        marcaDto.Codigo = marcaModel.Id;
        marcaDto.Nome = marcaModel.Nome;

        return Ok(marcaDto);
    }
}