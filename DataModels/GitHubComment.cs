using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubComment
{
    [JsonPropertyName("author_association")] public string AuthorAssociation { get; set; } = string.Empty;
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("commit_id")] public string CommitId { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("diff_hunk")] public string DiffHunk { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("original_commit_id")] public string OriginalCommitId { get; set; } = string.Empty;
    [JsonPropertyName("original_line")] public long? OriginalLine { get; set; }
    [JsonPropertyName("original_position")] public long? OriginalPosition { get; set; }
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("pull_request_review_id")] public long? PullRequestReviewId { get; set; }
    [JsonPropertyName("side")] public string Side { get; set; } = string.Empty;
    [JsonPropertyName("subject_type")] public string SubjectType { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
