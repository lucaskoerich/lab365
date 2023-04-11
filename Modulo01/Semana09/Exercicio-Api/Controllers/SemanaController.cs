using Exercicio_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_Api.Controllers;

[Route("[controller]")]
[ApiController]
public class SemanaController : Controller
{
    private readonly SemanaContext _semanaContext;

    public SemanaController(SemanaContext semanaContext)
    {
        _semanaContext = semanaContext;
    }

    [HttpGet]
    public ActionResult<List<SemanaModel>> GetTodos()
    {
        var listaSemanaModel = _semanaContext.Semana;
        List<SemanaModel> listaGetTodos = new List<SemanaModel>();

        foreach (var item in listaSemanaModel)
        {
            var semanaGetTodos = new SemanaModel();
            semanaGetTodos.Id = item.Id;
            semanaGetTodos.DataSemana = item.DataSemana;
            semanaGetTodos.Conteudo = item.Conteudo;
            semanaGetTodos.AplicadoConteudo = item.AplicadoConteudo;

            listaGetTodos.Add(semanaGetTodos);
        }

        return Ok(listaGetTodos);
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult GetPorId([FromRoute] int id)
    {
        SemanaModel _semanaModel = _semanaContext.Semana.Find(id);

        if (_semanaModel != null)
        {
            return Ok(_semanaModel);
        }

        return BadRequest("ID não encontrado!");
    }

    [HttpPost]
    public ActionResult Post([FromBody] SemanaModel semanaModel)
    {
        if (semanaModel.Id >= 0)
        {
            SemanaModel _semanaModel = new SemanaModel();
            _semanaModel.DataSemana = semanaModel.DataSemana;
            _semanaModel.Conteudo = semanaModel.Conteudo;
            _semanaModel.AplicadoConteudo = semanaModel.AplicadoConteudo;

            _semanaContext.Add(_semanaModel);
            _semanaContext.SaveChanges();
            return Ok(_semanaModel);
        }

        return BadRequest("ID precisa ser maior que 0");
    }

    [HttpPut]
    public ActionResult Put([FromBody] SemanaModel semanaModel)
    {
        SemanaModel _semanaModel = _semanaContext.Semana.Find(semanaModel.Id);

        if (_semanaModel.Id != null)
        {
            _semanaModel.DataSemana = semanaModel.DataSemana;
            _semanaModel.Conteudo = semanaModel.Conteudo;
            _semanaModel.AplicadoConteudo = semanaModel.AplicadoConteudo;

            _semanaContext.Attach(_semanaModel);
            _semanaContext.SaveChanges();
            return Ok(semanaModel);
        }

        return BadRequest("ID não encontrado!");
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete([FromRoute] int id)
    {
        SemanaModel _semanaModel = _semanaContext.Semana.Find(id);

        if (_semanaModel != null)
        {
            _semanaContext.Remove(_semanaModel);
            _semanaContext.SaveChanges();
            return Ok();
        }

        return BadRequest("ID não encontrado!");
    }
}