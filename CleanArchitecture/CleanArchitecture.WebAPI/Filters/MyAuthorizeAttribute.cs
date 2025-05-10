using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.WebAPI.Filters;

public class MyAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    private readonly string _role;
    public MyAuthorizeAttribute(string role)
    {
        _role = role;
    }
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        //eğer yetkisi yoksa
        if (true)
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
