using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubIssue
{
    [JsonPropertyName("assignee")] public GitHubUser? Assignee { get; set; }
    [JsonPropertyName("assignees")] public GitHubUser[]? Assignees { get; set; }
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("closed_at")] public DateTimeOffset? ClosedAt { get; set; }
    [JsonPropertyName("comments")] public long Comments { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("labels")] public GitHubLabel[]? Labels { get; set; }
    [JsonPropertyName("locked")] public bool Locked { get; set; }
    [JsonPropertyName("number")] public long? Number { get; set; }
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty;
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
