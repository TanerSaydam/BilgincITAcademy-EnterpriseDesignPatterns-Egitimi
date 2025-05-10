using CleanArchitecture.Domain.Dtos;

namespace CleanArchitecture.Application.Services;
public interface IKeycloakService
{
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default);
    Task<TokenResponse> LoginAsync(string username, string password, CancellationToken cancellationToken = default);
}
