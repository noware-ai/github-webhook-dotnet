using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubWorkflow
{
    [JsonPropertyName("badge_url")] public string BadgeUrl { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
}
