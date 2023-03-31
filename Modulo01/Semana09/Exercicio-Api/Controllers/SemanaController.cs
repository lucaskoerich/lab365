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
    public ActionResult Get()
    {
        return Ok();
    }
    
    [HttpGet]
    [Route("{id}")]
    public ActionResult Get([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public ActionResult Post([FromBody] SemanaModel semanaModel)
    {
        if (semanaModel.Id > 0)
        {
            return Ok();
        }

        return BadRequest("ID precisa ser maior que 0");
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Put([FromBody] SemanaModel semanaModel, [FromRoute] int id)
    {
        if (semanaModel.Id == id)
        {
            return Ok();
        }

        return BadRequest("ID não encontrado!");
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete([FromRoute] int id)
    {
        // if ()
        // {
        //     return Ok();
        // }

        return BadRequest("ID não encontrado!");
    }
    
    
    
    
}