using Microsoft.AspNetCore.Mvc;

namespace GatewayApi.Api.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<dynamic>> Get()
    {
        await Task.CompletedTask;
        _logger.LogInformation("Get");
        return Ok(Request.Headers);
    }

    [HttpPost]
    public async Task<ActionResult<dynamic>> Post()
    {
        await Task.CompletedTask;
        _logger.LogInformation("Post");
        return Ok((Request.Headers, Request.Body));
    }
}
