using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BandaController : ControllerBase
{
    [HttpPost]
    public ActionResult Post()
    {
        return Ok(true);
    }
}