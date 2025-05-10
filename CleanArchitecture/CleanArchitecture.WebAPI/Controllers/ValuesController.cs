using CleanArchitecture.Application.Products;
using CleanArchitecture.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace CleanArchitecture.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpPost]
    //[Authorize("getall")]
    //[TestFilter]
    [MyAuthorize("GetAll")]
    [EnableRateLimiting("fixed2")]
    public IActionResult Test(ProductCreateCommandRequest request)
    {
        return Ok("is working..");
    }
}
