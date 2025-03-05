using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.MvcApi.Controllers;

public class OrganizationController : Controller
{
    [HttpGet("/api/organizations")]
    public async Task<IActionResult> GetOrganizations([FromServices] IWebHostEnvironment env)
    {
        var file = Path.Combine(env.ContentRootPath, "App_Data", "organizations.json");
        var organizations = await System.IO.File.ReadAllTextAsync(file);
        return Content(organizations, "application/json");
    }
}
