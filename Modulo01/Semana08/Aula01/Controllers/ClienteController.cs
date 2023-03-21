using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers;

[ApiController]
[Route("Cliente")]
public class ClienteController : Controller
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Oie");
    }
}