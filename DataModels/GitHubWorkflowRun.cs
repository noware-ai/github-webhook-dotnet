using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubWorkflowRun
{
    [JsonPropertyName("actor")] public GitHubUser? Actor { get; set; }
    [JsonPropertyName("check_suite_id")] public long CheckSuiteId { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("display_title")] public string DisplayTitle { get; set; } = string.Empty;
    [JsonPropertyName("event")] public string Event { get; set; } = string.Empty;
    [JsonPropertyName("head_branch")] public string HeadBranch { get; set; } = string.Empty;
    [JsonPropertyName("head_commit")] public GitHubCommit? HeadCommit { get; set; }
    [JsonPropertyName("head_repository")] public GitHubRepository? HeadRepository { get; set; }
    [JsonPropertyName("head_sha")] public string HeadSHA { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("previous_attempt_url")] public string PreviousAttemptUrl { get; set; } = string.Empty;
    [JsonPropertyName("pull_requests")] public object[]? PullRequests { get; set; } = null;
    [JsonPropertyName("referenced_workflows")] public object[]? ReferencedWorkflows { get; set; } = null;
    [JsonPropertyName("repository")] public GitHubRepository? Repository { get; set; }
    [JsonPropertyName("run_attempt")] public long RunAttempt { get; set; }
    [JsonPropertyName("run_number")] public long RunNumber { get; set; }
    [JsonPropertyName("run_started_at")] public DateTimeOffset? RunStartedAt { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
    [JsonPropertyName("triggering_actor")] public GitHubUser? TriggeringActor { get; set; }
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonPropertyName("workflow_id")] public long WorkflowId { get; set; }
}
