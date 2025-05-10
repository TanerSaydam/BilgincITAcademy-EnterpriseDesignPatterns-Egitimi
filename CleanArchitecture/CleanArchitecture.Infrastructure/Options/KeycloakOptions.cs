namespace CleanArchitecture.Infrastructure.Options;
public sealed class KeycloakOptions
{
    public string Url { get; set; } = default!;
    public string Realm { get; set; } = default!;
    public string ClientId { get; set; } = default!;
    public string ClientSecret { get; set; } = default!;
}
