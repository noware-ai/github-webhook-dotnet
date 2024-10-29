using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubDiscussionAnswer
{
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("discussion_id")] public long DiscussionId { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
