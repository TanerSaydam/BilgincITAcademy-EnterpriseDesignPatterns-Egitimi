using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.WebAPI.Filters;

public class TestFilter : Attribute, IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        //throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        //throw new NotImplementedException();
    }
}
