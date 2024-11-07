using System.Text.Json.Serialization;
using Noware.GitHub.Webhooks.Models.DataModels;

namespace Noware.GitHub.Webhooks.Models;

public class GitHubWebhookPayload
{
    [JsonPropertyName("action")] public string Action { get; set; } = "";
    [JsonPropertyName("after")] public string? After { get; set; } = null;
    [JsonPropertyName("alert")] public GitHubAlert? Alert { get; set; } = null;
    [JsonPropertyName("answer")] public GitHubDiscussionAnswer? Answer { get; set; } = null;
    [JsonPropertyName("base_ref")] public string? BaseRef { get; set; } = null;
    [JsonPropertyName("before")] public string? Before { get; set; } = null;
    [JsonPropertyName("changes")] public GitHubChanges? Changes { get; set; } = null;
    [JsonPropertyName("check_run")] public GitHubCheckRun? CheckRun { get; set; } = null;
    [JsonPropertyName("check_suite")] public GitHubCheckSuite? CheckSuite { get; set; } = null;
    [JsonPropertyName("comment")] public GitHubComment? Comment { get; set; } = null;
    [JsonPropertyName("commit_oid")] public string? CommitOid { get; set; } = null;
    [JsonPropertyName("commits")] public GitHubCommit[]? Commits { get; set; } = null;
    [JsonPropertyName("compare")] public string? Compare { get; set; } = null;
    [JsonPropertyName("created")] public bool? Created { get; set; } = null;
    [JsonPropertyName("deleted")] public bool? Deleted { get; set; } = null;
    [JsonPropertyName("discussion")] public GitHubDiscussion? Discussion { get; set; } = null;
    [JsonPropertyName("enterprise")] public GitHubEnterprise? Enterprise { get; set; } = null;
    [JsonPropertyName("forced")] public bool? Forced { get; set; } = null;
    [JsonPropertyName("head_commit")] public GitHubCommit? HeadCommit { get; set; } = null;
    [JsonPropertyName("issue")] public GitHubIssue? Issue { get; set; } = null;
    [JsonPropertyName("member")] public GitHubUser? Member { get; set; } = null;
    [JsonPropertyName("merge_group")] public GitHubMergeGroup? MergeGroup { get; set; } = null;
    [JsonPropertyName("number")] public long Number { get; set; }
    [JsonPropertyName("organization")] public GitHubOrganization? Organization { get; set; } = null;
    [JsonPropertyName("parent_issue")] public GitHubIssue? ParentIssue { get; set; } = null;
    [JsonPropertyName("parent_issue_id")] public long ParentIssueId { get; set; }
    [JsonPropertyName("parent_issue_repo")] public GitHubRepository? ParentIssueRepo { get; set; } = null;
    [JsonPropertyName("pull_request")] public GitHubPullRequest? PullRequest { get; set; } = null;
    [JsonPropertyName("pusher")] public GitUser? Pusher { get; set; } = null;
    [JsonPropertyName("pusher_type")] public string? PusherType { get; set; } = null;
    [JsonPropertyName("reason")] public string? Reason { get; set; } = null;
    [JsonPropertyName("ref")] public string? Ref { get; set; } = null;
    [JsonPropertyName("ref_type")] public string? RefType { get; set; } = null;
    [JsonPropertyName("release")] public GitHubRelease? Release { get; set; } = null;
    [JsonPropertyName("repository")] public GitHubRepository? Repository { get; set; } = null;
    [JsonPropertyName("sender")] public GitHubUser? Sender { get; set; } = null;
    [JsonPropertyName("starred_at")] public DateTimeOffset? StarredAt { get; set; } = null;
    [JsonPropertyName("sub_issue")] public GitHubIssue? SubIssue { get; set; } = null;
    [JsonPropertyName("sub_issue_id")] public long SubIssueId { get; set; }
    [JsonPropertyName("thread")] public GitHubThread? Thread { get; set; } = null;
    [JsonPropertyName("type")] public GitHubType? Type { get; set; } = null;
    [JsonPropertyName("workflow")] public GitHubWorkflow? Workflow { get; set; } = null;
    [JsonPropertyName("workflow_job")] public GitHubWorkflowJob? WorkflowJob { get; set; } = null;
    [JsonPropertyName("workflow_run")] public GitHubWorkflowRun? WorkflowRun { get; set; } = null;
}
