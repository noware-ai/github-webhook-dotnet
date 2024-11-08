using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Noware.GitHub.Webhooks.Models;

public static class GitHubWebhook
{
    /// <summary>
    /// Given a GitHub webhook HTTP request, it returns the GitHub event type and payload
    /// </summary>
    /// <param name="requestBody">HTTP body</param>
    /// <param name="reqHeaders">HTTP headers</param>
    /// <param name="log">App logger</param>
    public static (GitHubWebhookPayload? eventPayload, GitHubEvents eventType) ParseEvent(
        string requestBody, Dictionary<string, StringValues> reqHeaders, ILogger log)
    {
        string gitHubEventName = reqHeaders.TryGetValue("X-GitHub-Event", out StringValues header) ? header.ToString() : string.Empty;
        log.LogInformation("X-GitHub-Event = {0}", gitHubEventName);

        // Deserialize body
        var data = JsonSerializer.Deserialize<GitHubWebhookPayload>(requestBody);
        if (data is null)
        {
            log.LogError("Deserialized payload to {0} failed and returned NULL", nameof(GitHubWebhookPayload));
            return (null, GitHubEvents.Unknown);
        }

        GitHubEvents eventType = GetEventType(gitHubEventName, requestBody, log);

        return (data, eventType);
    }

    public static GitHubEvents GetEventType(string eventName, string eventPayloadAsJson, ILogger log)
    {
        Dictionary<string, JsonElement>? payload = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(eventPayloadAsJson);
        if (payload == null)
        {
            log.LogError("Deserialized payload to {0} failed and returned NULL", nameof(Dictionary<string, JsonElement>));
            return GitHubEvents.Unknown;
        }

        string? action = null;
        if (payload.TryGetValue("action", out JsonElement jaction))
        {
            action = jaction.GetString();
            log.LogInformation("Action = {0}", action);
        }

        switch (eventName)
        {
            case "watch":
                // TODO
                break;
            case "create":
                // TODO
                break;
            case "delete":
                // TODO
                break;
            case "deployment":
                // TODO
                break;
            case "deployment_status":
                // TODO
                break;
            case "fork":
                // TODO
                break;
            case "merge_group":
                // TODO
                break;
            case "push":
                // TODO
                break;
            case "code_scanning_alert":
                switch (action)
                {
                    case "fixed": return GitHubEvents.CodeScanningAlertFixed;
                    case "reopened": return GitHubEvents.CodeScanningAlertReopened;
                    case "resolve": return GitHubEvents.CodeScanningAlertResolve;
                }
                break;
            case "package":
                switch (action)
                {
                    case "published": return GitHubEvents.PackagePublished;
                }
                break;
            case "registry_package":
                switch (action)
                {
                    case "published": return GitHubEvents.RegistryPackagePublished;
                }
                break;
            case "star":
                switch (action)
                {
                    case "created": return GitHubEvents.StarredAtCreated;
                    case "deleted": return GitHubEvents.StarredAtDeleted;
                }
                break;
            case "ping":
                if (action == null && payload.ContainsKey("hook")) { return GitHubEvents.WebhookPing; }

                break;
            case "issues":
                switch (action)
                {
                    case "assigned": return GitHubEvents.IssueAssigned;
                    case "closed": return GitHubEvents.IssueClosed;
                    case "edited": return GitHubEvents.IssueEdited;
                    case "labeled": return GitHubEvents.IssueLabeled;
                    case "opened": return GitHubEvents.IssueOpened;
                    case "reopened": return GitHubEvents.IssueReopened;
                    case "typed": return GitHubEvents.IssueTyped;
                    case "unassigned": return GitHubEvents.IssueUnassigned;
                    case "unlabeled": return GitHubEvents.IssueUnlabeled;
                }

                break;
            case "pull_request":
                switch (action)
                {
                    case "assigned": return GitHubEvents.PullRequestAssigned;
                    case "auto_merge_disabled": return GitHubEvents.PullRequestAutoMergeDisabled;
                    case "auto_merge_enabled": return GitHubEvents.PullRequestAutoMergeEnabled;
                    case "closed": return GitHubEvents.PullRequestClosed;
                    case "dequeued": return GitHubEvents.PullRequestDequeued;
                    case "edited": return GitHubEvents.PullRequestEdited;
                    case "enqueued": return GitHubEvents.PullRequestEnqueued;
                    case "labeled": return GitHubEvents.PullRequestLabeled;
                    case "opened": return GitHubEvents.PullRequestOpened;
                    case "ready_for_review": return GitHubEvents.PullRequestReadyForReview;
                    case "resolved": return GitHubEvents.PullRequestResolved;
                    case "review_requested": return GitHubEvents.PullRequestReviewRequested;
                    case "submitted": return GitHubEvents.PullRequestSubmitted;
                    case "synchronize": return GitHubEvents.PullRequestSynchronize;
                    case "unlabeled": return GitHubEvents.PullRequestUnlabeled;
                }
                break;
            case "pull_request_review":
                switch (action)
                {
                    case "submitted": return GitHubEvents.PullRequestReviewSubmitted;
                }
                break;
            case "pull_request_review_thread":
                switch (action)
                {
                    case "resolved": return GitHubEvents.PullRequestThreadResolved;
                }
                break;
        }

        // Fallback to old parsing logic
        return GetEventTypeLegacy(action, payload, log);
    }

    private static GitHubEvents GetEventTypeLegacy(string? action, Dictionary<string, JsonElement> payload, ILogger log)
    {
        switch (action)
        {
            case "answered":
                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionAnswered; }

                break;
            case "checks_requested":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupChecksRequested; }

                break;
            case "closed":
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

                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionCreated; }

                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseCreated; }

                if (payload.ContainsKey("check_run")) { return GitHubEvents.CheckRunCreated; }

                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCreated; }

                break;
            case "deleted":
                if (payload.ContainsKey("issue") && payload.ContainsKey("comment")) { return GitHubEvents.IssueCommentDeleted; }

                if (payload.ContainsKey("pull_request") && payload.ContainsKey("comment")) { return GitHubEvents.PullRequestCommentDeleted; }

                if (payload.ContainsKey("discussion") && payload.ContainsKey("comment")) { return GitHubEvents.DiscussionCommentDeleted; }

                break;
            case "destroyed":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupDestroyed; }

                break;
            case "edited":
                if (payload.ContainsKey("issue") && payload.ContainsKey("comment")) { return GitHubEvents.IssueCommentEdited; }

                if (payload.ContainsKey("pull_request") && payload.ContainsKey("comment")) { return GitHubEvents.PullRequestCommentEdited; }

                if (payload.ContainsKey("discussion") && payload.ContainsKey("comment")) { return GitHubEvents.DiscussionCommentEdited; }

                if (payload.ContainsKey("discussion")) { return GitHubEvents.DiscussionEdited; }

                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseEdited; }

                if (payload.ContainsKey("member") && payload.ContainsKey("changes")) { return GitHubEvents.RepoSettingsEdited; }

                break;
            case "in_progress":
                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunInProgress; }

                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobInProgress; }

                break;
            case "sub_issue_added":
                if (payload.ContainsKey("sub_issue")) { return GitHubEvents.SubIssueAdded; }

                break;
            case "parent_issue_added":
                if (payload.ContainsKey("parent_issue")) { return GitHubEvents.ParentIssueAdded; }

                break;
            case "published":
                if (payload.ContainsKey("release")) { return GitHubEvents.ReleasePublished; }

                break;
            case "queued":
                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobQueued; }

                break;
            case "released":
                if (payload.ContainsKey("release")) { return GitHubEvents.ReleaseReleased; }

                break;
            case "requested":
                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunRequested; }

                break;
            case "started":
                if (payload.ContainsKey("sender")) { return GitHubEvents.LooksLikeRepoWatchCreated; }

                break;
            case "waiting":
                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobWaiting; }

                break;
            default:
                // if (payload.ContainsKey("zen")
                //     && payload.ContainsKey("hook_id")
                //     && payload.ContainsKey("hook"))
                // {
                //     return GitHubEvents.LooksLikeAWebhookAction;
                // }

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
