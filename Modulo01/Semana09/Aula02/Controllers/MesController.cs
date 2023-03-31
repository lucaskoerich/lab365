using Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula02.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MesController : Controller
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public ActionResult Post([FromBody] MesModel mesModel)
    {
        return Ok(true);
    }

    [HttpPut]
    public ActionResult Put()
    {
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete([FromRoute] int id)
    {
        return Ok();
    }
}