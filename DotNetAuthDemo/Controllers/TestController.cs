using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAuthDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    // create a get endpoint that requires the "WEATHER_READ" policy
    [HttpGet]
    [Authorize(Policy = "READ_ONLY")]
    public string Get()
    {
        return "Hello, World!";
    }
}