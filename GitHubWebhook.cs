using System.Text.Json;
using Microsoft.Extensions.Primitives;

namespace Noware.GitHub.Webhooks.Models;

public static class GitHubWebhook
{
    /// <summary>
    /// Given a GitHub webhook HTTP request, it returns the GitHub event type and payload
    /// </summary>
    /// <param name="requestBody">HTTP body</param>
    /// <param name="reqHeaders">HTTP headers</param>
    public static (GitHubWebhookPayload? eventPayload, GitHubEvents eventType) ParseEvent(string requestBody, Dictionary<string, StringValues> reqHeaders)
    {
        string gitHubEventName = reqHeaders.TryGetValue("X-GitHub-Event", out StringValues header) ? header.ToString() : string.Empty;

        // Deserialize body
        var data = JsonSerializer.Deserialize<GitHubWebhookPayload>(requestBody);
        if (data is null)
        {
            return (null, GitHubEvents.Unknown);
        }

        GitHubEvents eventType = GetEventType(gitHubEventName, requestBody);

        return (data, eventType);
    }

    public static GitHubEvents GetEventType(string eventName, string eventPayloadAsJson)
    {
        Dictionary<string, JsonElement>? payload = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(eventPayloadAsJson);
        if (payload == null) { return GitHubEvents.Unknown; }

        string? action = null;
        if (payload.TryGetValue("action", out JsonElement jaction))
        {
            action = jaction.GetString();
        }

        switch (eventName)
        {
            case "ping":
                if (action == null && payload.ContainsKey("hook")) { return GitHubEvents.WebhookPing; }

                break;
            case "issues":
                switch (action)
                {
                    case "reopened": return GitHubEvents.IssueReopened;
                    case "assigned": return GitHubEvents.IssueAssigned;
                    case "closed": return GitHubEvents.IssueClosed;
                    case "edited": return GitHubEvents.IssueEdited;
                    case "labeled": return GitHubEvents.IssueLabeled;
                    case "opened": return GitHubEvents.IssueOpened;
                    case "typed": return GitHubEvents.IssueTyped;
                    case "unassigned": return GitHubEvents.IssueUnassigned;
                    case "unlabeled": return GitHubEvents.IssueUnlabeled;
                }

                break;
            default:
                return GitHubEvents.Unknown;
        }

        // Fallback to old parsing logic
        return GetEventTypeLegacy(action, payload);
    }

    private static GitHubEvents GetEventTypeLegacy(string? action, Dictionary<string, JsonElement> payload)
    {
        switch (action)
        {
            case "answered":
                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionAnswered; }

                break;
            case "assigned":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueAssigned; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestAssigned; }

                break;
            case "auto_merge_enabled":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestAutoMergeEnabled; }

                break;
            case "auto_merge_disabled":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestAutoMergeDisabled; }

                break;
            case "checks_requested":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupChecksRequested; }

                break;
            case "closed":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueClosed; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestClosed; }

                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionClosed; }

                break;
            case "completed":
                if (payload.ContainsKey("check_run")) { return GitHubEvents.CheckRunCompleted; }

                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCompleted; }

                if (payload.ContainsKey("check_suite")) { return GitHubEvents.CheckSuiteCompleted; }

                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobCompleted; }

                break;
            case "created":
                if (payload.ContainsKey("issue") && payload.ContainsKey("comment")) { return GitHubEvents.IssueCommentCreated; }

                if (payload.ContainsKey("pull_request") && payload.ContainsKey("comment")) { return GitHubEvents.PullRequestCommentCreated; }

                if (payload.ContainsKey("discussion") && payload.ContainsKey("comment")) { return GitHubEvents.DiscussionCommentCreated; }

                if (payload.ContainsKey("starred_at")) { return GitHubEvents.StarredAtCreated; }

                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionCreated; }

                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseCreated; }

                if (payload.ContainsKey("check_run")) { return GitHubEvents.CheckRunCreated; }

                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCreated; }

                break;
            case "deleted":
                if (payload.ContainsKey("issue") && payload.ContainsKey("comment")) { return GitHubEvents.IssueCommentDeleted; }

                if (payload.ContainsKey("pull_request") && payload.ContainsKey("comment")) { return GitHubEvents.PullRequestCommentDeleted; }

                if (payload.ContainsKey("discussion") && payload.ContainsKey("comment")) { return GitHubEvents.DiscussionCommentDeleted; }

                if (payload.ContainsKey("starred_at")) { return GitHubEvents.StarredAtDeleted; }

                break;
            case "dequeued":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestDequeued; }

                break;
            case "destroyed":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupDestroyed; }

                break;
            case "edited":
                if (payload.ContainsKey("issue") && payload.ContainsKey("comment")) { return GitHubEvents.IssueCommentEdited; }

                if (payload.ContainsKey("pull_request") && payload.ContainsKey("comment")) { return GitHubEvents.PullRequestCommentEdited; }

                if (payload.ContainsKey("discussion") && payload.ContainsKey("comment")) { return GitHubEvents.DiscussionCommentEdited; }

                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionEdited; }

                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueEdited; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestEdited; }

                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseEdited; }

                if (payload.ContainsKey("member") && payload.ContainsKey("changes")) { return GitHubEvents.RepoSettingsEdited; }

                break;
            case "enqueued":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestEnqueued; }

                break;
            case "fixed":
                if (payload.ContainsKey("alert")) { return GitHubEvents.AlertFixed; }

                break;
            case "in_progress":
                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunInProgress; }

                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobInProgress; }

                break;
            case "labeled":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueLabeled; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestLabeled; }

                break;
            case "opened":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueOpened; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestOpened; }

                break;
            case "sub_issue_added":
                if (payload.ContainsKey("sub_issue")) { return GitHubEvents.SubIssueAdded; }

                break;
            case "parent_issue_added":
                if (payload.ContainsKey("parent_issue")) { return GitHubEvents.ParentIssueAdded; }

                break;
            case "published":
                if (payload.ContainsKey("registry_package")) { return GitHubEvents.RegistryPackagePublished; }

                if (payload.ContainsKey("package")) { return GitHubEvents.PackagePublished; }

                if (payload.ContainsKey("release")) { return GitHubEvents.ReleasePublished; }

                break;
            case "queued":
                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobQueued; }

                break;
            case "ready_for_review":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestReadyForReview; }

                break;
            case "released":
                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseReleased; }

                break;
            case "reopened":
                if (payload.ContainsKey("alert")) { return GitHubEvents.AlertReopened; }

                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueReopened; }

                break;
            case "requested":
                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunRequested; }

                break;
            case "resolve":
                if (payload.ContainsKey("alert")) { return GitHubEvents.AlertResolve; }

                break;
            case "resolved":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestResolved; }

                break;
            case "review_requested":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestReviewRequested; }

                break;
            case "submitted":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestSubmitted; }

                break;
            case "started":
                if (payload.ContainsKey("sender")) { return GitHubEvents.LooksLikeRepoWatchCreated; }

                break;
            case "synchronize":
                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestSynchronize; }

                break;
            case "typed":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueTyped; }

                break;
            case "unassigned":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueUnassigned; }

                break;
            case "unlabeled":
                if (payload.ContainsKey("issue")) { return GitHubEvents.IssueUnlabeled; }

                if (payload.ContainsKey("pull_request")) { return GitHubEvents.PullRequestUnlabeled; }

                break;
            case "waiting":
                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobWaiting; }

                break;
            default:
                if (payload.ContainsKey("zen")
                    && payload.ContainsKey("hook_id")
                    && payload.ContainsKey("hook"))
                {
                    return GitHubEvents.LooksLikeAWebhookAction;
                }

                if (payload.ContainsKey("ref")
                    && payload.ContainsKey("before")
                    && payload.ContainsKey("after")
                    && payload.ContainsKey("compare")
                    && payload.ContainsKey("pusher")
                    && payload.ContainsKey("sender")
                    && payload.ContainsKey("created")
                    && payload.ContainsKey("deleted")
                    && payload.ContainsKey("forced")
                   )
                {
                    return GitHubEvents.LooksLikeABranchPush;
                }

                if (payload.ContainsKey("ref")
                    && payload.ContainsKey("ref_type")
                    && payload.ContainsKey("sender")
                   )
                {
                    return GitHubEvents.LooksLikeAMergeFromQueue;
                }

                if (payload.ContainsKey("forkee"))
                {
                    return GitHubEvents.LooksLikeANewFork;
                }

                return GitHubEvents.Unknown;
        }

        return GitHubEvents.Unknown;
    }
}
