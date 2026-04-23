namespace LigerZero.Common.Config;

public sealed class LoginConfig
{
    [JsonPropertyName("username")] public string Username { get; set; } = string.Empty;
    [JsonPropertyName("server")] public string Server { get; set; } = string.Empty;
}
