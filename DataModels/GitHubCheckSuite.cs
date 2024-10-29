using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubCheckSuite
{
    [JsonPropertyName("after")] public string After { get; set; } = string.Empty;
    [JsonPropertyName("app")] public GitHubApp? App { get; set; } = null;
    [JsonPropertyName("before")] public string Before { get; set; } = string.Empty;
    [JsonPropertyName("conclusion")] public string Conclusion { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("head_branch")] public string HeadBranch { get; set; } = string.Empty;
    [JsonPropertyName("head_sha")] public string HeadSHA { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("pull_requests")] public object[]? PullRequests { get; set; } = null;
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
}
