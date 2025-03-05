using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.MvcApi.Controllers;

public class UserController : Controller
{
    [HttpGet("/api/user")]
    public async Task<IActionResult> GetUsers([FromServices] IWebHostEnvironment env)
    {
        var file = Path.Combine(env.ContentRootPath, "App_Data", "user.json");
        var user = await System.IO.File.ReadAllTextAsync(file);
        return Content(user, "application/json");
    }
}