using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubWorkflowJob
{
    [JsonPropertyName("check_run_url")] public string CheckRunUrl { get; set; } = string.Empty;
    [JsonPropertyName("completed_at")] public DateTimeOffset? CompletedAt { get; set; }
    [JsonPropertyName("conclusion")] public object? Conclusion { get; set; } = null;
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("head_branch")] public string HeadBranch { get; set; } = string.Empty;
    [JsonPropertyName("head_sha")] public string HeadSHA { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("labels")] public string[]? Labels { get; set; } = null;
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("run_attempt")] public long RunAttempt { get; set; }
    [JsonPropertyName("run_id")] public long RunId { get; set; }
    [JsonPropertyName("runner_group_id")] public long? RunnerGroupId { get; set; }
    [JsonPropertyName("runner_group_name")] public string RunnerGroupName { get; set; } = string.Empty;
    [JsonPropertyName("runner_id")] public long? RunnerId { get; set; }
    [JsonPropertyName("runner_name")] public string RunnerName { get; set; } = string.Empty;
    [JsonPropertyName("started_at")] public DateTimeOffset? StartedAt { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
    [JsonPropertyName("steps")] public object[]? Steps { get; set; } = null;
    [JsonPropertyName("workflow_name")] public string WorkflowName { get; set; } = string.Empty;
}
