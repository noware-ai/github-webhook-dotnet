using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubHook
{
    [JsonPropertyName("active")] public bool Active { get; set; }
    [JsonPropertyName("config")] public object? Config { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("events")] public string[]? Events { get; set; } = null;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("last_response")] public object? LastResponse { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
}
