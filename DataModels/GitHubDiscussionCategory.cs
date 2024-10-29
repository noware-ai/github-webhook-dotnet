using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubDiscussionCategory
{
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("emoji")] public string Emoji { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("is_answerable")] public bool IsAnswerable { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("repository_id")] public long RepositoryId { get; set; }
    [JsonPropertyName("slug")] public string Slug { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
}
