using MediatR;

namespace CleanArchitecture.Application.Behaviors;
public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : class, IRequest<TResponse>
{

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        //metodun başında
        var res = await next();
        //metodun sonunda
        return res;
    }
}
