using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubPullRequest
{
    [JsonPropertyName("active_lock_reason")] public object? ActiveLockReason { get; set; }
    [JsonPropertyName("additions")] public int Additions { get; set; }
    [JsonPropertyName("assignee")] public GitHubUser? Assignee { get; set; }
    [JsonPropertyName("assignees")] public GitHubUser[]? Assignees { get; set; }
    [JsonPropertyName("author_association")] public string AuthorAssociation { get; set; } = string.Empty;
    [JsonPropertyName("auto_merge")] public object? AutoMerge { get; set; }
    [JsonPropertyName("base")] public object? Base { get; set; }
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("changed_files")] public int ChangedFiles { get; set; }
    [JsonPropertyName("closed_at")] public DateTimeOffset? ClosedAt { get; set; }
    [JsonPropertyName("comments")] public int Comments { get; set; }
    [JsonPropertyName("commits")] public int Commits { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("deletions")] public int Deletions { get; set; }
    [JsonPropertyName("diff_url")] public string DiffUrl { get; set; } = string.Empty;
    [JsonPropertyName("draft")] public bool? Draft { get; set; }
    [JsonPropertyName("head")] public object? Head { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("issue_url")] public string IssueUrl { get; set; } = string.Empty;
    [JsonPropertyName("labels")] public GitHubLabel[]? Labels { get; set; }
    [JsonPropertyName("locked")] public bool Locked { get; set; }
    [JsonPropertyName("maintainer_can_modify")] public bool MaintainerCanModify { get; set; }
    [JsonPropertyName("merge_commit_sha")] public string MergeCommitSHA { get; set; } = string.Empty;
    [JsonPropertyName("mergeable")] public bool? Mergeable { get; set; }
    [JsonPropertyName("mergeable_state")] public string MergeableState { get; set; } = string.Empty;
    [JsonPropertyName("merged")] public bool Merged { get; set; }
    [JsonPropertyName("merged_at")] public DateTimeOffset? MergedAt { get; set; }
    [JsonPropertyName("merged_by")] public object? MergedBy { get; set; }
    [JsonPropertyName("milestone")] public object? Milestone { get; set; }
    [JsonPropertyName("number")] public long Number { get; set; }
    [JsonPropertyName("patch_url")] public string PatchUrl { get; set; } = string.Empty;
    [JsonPropertyName("rebaseable")] public bool? Rebaseable { get; set; }
    [JsonPropertyName("requested_reviewers")] public GitHubUser[]? RequestedReviewers { get; set; }
    [JsonPropertyName("requested_teams")] public GitHubTeam[]? RequestedTeams { get; set; }
    [JsonPropertyName("review_comments")] public int ReviewComments { get; set; }
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty;
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
