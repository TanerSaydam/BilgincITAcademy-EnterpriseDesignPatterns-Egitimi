using System.Text.Json;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Infrastructure.Options;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Infrastructure.Services;
internal sealed class KeycloakService(
    HttpClient httpClient,
    IOptions<KeycloakOptions> options) : IKeycloakService
{
    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        string enpoint = $"{options.Value.Url}/realms/{options.Value.Realm}/protocol/openid-connect/token";
        List<KeyValuePair<string, string>> data = new();
        var grantType = new KeyValuePair<string, string>("grant_type", "client_credentials");
        var client_id = new KeyValuePair<string, string>("client_id", options.Value.ClientId);
        var client_secret = new KeyValuePair<string, string>("client_secret", options.Value.ClientSecret);

        data.AddRange(grantType, client_id, client_secret);


        var message = await httpClient.PostAsync(enpoint, new FormUrlEncodedContent(data), cancellationToken);
        var res = await message.Content.ReadAsStringAsync();

        if (message.IsSuccessStatusCode)
        {
            var obj = JsonSerializer.Deserialize<GetAccessTokenResponse>(res)!;
            return obj.access_token;
        }

        throw new ArgumentException("Something went wrong");

    }

    public async Task<TokenResponse> LoginAsync(string username, string password, CancellationToken cancellationToken = default)
    {
        string enpoint = $"{options.Value.Url}/realms/{options.Value.Realm}/protocol/openid-connect/token";

        List<KeyValuePair<string, string>> data = new();
        var grantType = new KeyValuePair<string, string>("grant_type", "password");
        var client_id = new KeyValuePair<string, string>("client_id", options.Value.ClientId);
        var client_secret = new KeyValuePair<string, string>("client_secret", options.Value.ClientSecret);
        var _username = new KeyValuePair<string, string>("username", username);
        var _password = new KeyValuePair<string, string>("password", password);

        data.Add(grantType);
        data.Add(client_id);
        data.Add(client_secret);
        data.Add(_username);
        data.Add(_password);

        var message = await httpClient.PostAsync(enpoint, new FormUrlEncodedContent(data), cancellationToken);
        var res = await message.Content.ReadAsStringAsync();

        if (message.IsSuccessStatusCode)
        {
            var obj = JsonSerializer.Deserialize<TokenResponse>(res)!;
            return obj;
        }

        throw new ArgumentException("Something went wrong");
    }
}
