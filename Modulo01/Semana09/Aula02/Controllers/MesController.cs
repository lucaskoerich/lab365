using Aula02.DTO;
using Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula02.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MesController : Controller
{
    private readonly MesContext _mesContext;

    public MesController(MesContext mesContext)
    {
        _mesContext = mesContext;
    }

    [HttpGet]
    public ActionResult<List<MesGetAllDTO>> Get()
    {
        var listaMesModel = _mesContext.Mes;
        List<MesGetAllDTO> listaGetAllDtos = new List<MesGetAllDTO>();

        foreach (var item in listaMesModel)
        {
            var mesGetAllDtos = new MesGetAllDTO();
            mesGetAllDtos.Id = item.Id;
            mesGetAllDtos.Mes = item.Nome;
            mesGetAllDtos.Ano = item.Ano;

            listaGetAllDtos.Add(mesGetAllDtos);
        }

        return Ok(listaGetAllDtos);
    }

    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public ActionResult Post([FromBody] MesDTO mesDto)
    {
        MesModel mesModel = new MesModel();
        // não preencher ID Model
        mesModel.Nome = mesDto.DataHoraEvento.ToString("MMM");
        mesModel.Ano = mesDto.DataHoraEvento.Year;

        _mesContext.Mes.Add(mesModel);
        _mesContext.SaveChanges();

        return Ok(mesModel);
    }

    [HttpPut]
    public ActionResult Put([FromBody] MesDTO mesDto)
    {
        MesModel mesModel = _mesContext.Mes.Where(x => x.Id == mesDto.Codigo).FirstOrDefault();

        if (mesModel != null)
        {
            mesModel.Ano = mesDto.DataHoraEvento.Year;
            _mesContext.Attach(mesModel);
            _mesContext.SaveChanges();
            return Ok(mesDto);
        }

        return BadRequest("ID não encontrado!");
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete([FromRoute] int id)
    {
        MesModel mesModel = _mesContext.Mes.Find(id);

        if (mesModel != null)
        {
            _mesContext.Remove(mesModel);
            _mesContext.SaveChanges();
            return Ok();
        }

        return BadRequest("ID não encontrado!");
    }
}