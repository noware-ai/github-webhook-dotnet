using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubCheckRun
{
    [JsonPropertyName("app")] public GitHubApp? App { get; set; } = null;
    [JsonPropertyName("check_suite")] public GitHubCheckSuite? CheckSuite { get; set; } = null;
    [JsonPropertyName("completed_at")] public DateTimeOffset? CompletedAt { get; set; }
    [JsonPropertyName("conclusion")] public string Conclusion { get; set; } = string.Empty;
    [JsonPropertyName("details_url")] public string DetailsUrl { get; set; } = string.Empty;
    [JsonPropertyName("external_id")] public string ExternalId { get; set; } = string.Empty;
    [JsonPropertyName("head_sha")] public string HeadSHA { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("output")] public object? Output { get; set; } = null;
    [JsonPropertyName("pull_requests")] public object[]? PullRequests { get; set; } = null;
    [JsonPropertyName("started_at")] public DateTimeOffset? StartedAt { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
}
