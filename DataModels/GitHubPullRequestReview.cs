using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubPullRequestReview
{
    [JsonPropertyName("author_association")] public string AuthorAssociation { get; set; } = string.Empty;
    [JsonPropertyName("body")] public object? Body { get; set; }
    [JsonPropertyName("commit_id")] public string CommitId { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty;
    [JsonPropertyName("submitted_at")] public DateTimeOffset? SubmittedAt { get; set; }
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
