using Microsoft.AspNetCore.Mvc;

namespace TinyUrl.Api.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class TinyUrlController : ControllerBase
{
    [HttpGet("{code}")]
    // GET
    public ActionResult Redirect(string code)
    {
        return Ok(code);
    }
}