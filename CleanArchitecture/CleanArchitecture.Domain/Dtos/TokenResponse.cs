using System.Text.Json.Serialization;

namespace CleanArchitecture.Domain.Dtos;
public class TokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = default!;

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("refresh_expires_in")]
    public int RefreshExpiresIn { get; set; }

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; } = default!;

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = default!;

    [JsonPropertyName("not-before-policy")]
    public int NotBeforePolicy { get; set; }

    [JsonPropertyName("session_state")]
    public string SessionState { get; set; } = default!;

    [JsonPropertyName("scope")]
    public string Scope { get; set; } = default!;
}
