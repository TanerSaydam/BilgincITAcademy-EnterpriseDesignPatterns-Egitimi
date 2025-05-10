using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Auth;
public sealed record LoginCommand(
    string UserName,
    string Password) : IRequest<TokenResponse>;

internal sealed class LoginCommandHandler(
    IKeycloakService keycloakService) : IRequestHandler<LoginCommand, TokenResponse>
{
    public async Task<TokenResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var res = await keycloakService.LoginAsync(request.UserName, request.Password, cancellationToken);
        return res;
    }
}
