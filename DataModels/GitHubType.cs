using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubType
{
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
}
