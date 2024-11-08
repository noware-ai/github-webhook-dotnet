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
            case "discussion":
                switch (action)
                {
                    case "answered": return GitHubEvents.DiscussionAnswered;
                    case "closed": return GitHubEvents.DiscussionClosed;
                    case "created": return GitHubEvents.DiscussionCreated;
                    case "edited": return GitHubEvents.DiscussionEdited;
                    case "labeled": return GitHubEvents.DiscussionLabeled;
                }

                break;
            case "discussion_comment":
                switch (action)
                {
                    case "created": return GitHubEvents.DiscussionCommentCreated;
                    case "deleted": return GitHubEvents.DiscussionCommentDeleted;
                    case "edited": return GitHubEvents.DiscussionCommentEdited;
                }

                break;
            case "package":
                switch (action)
                {
                    case "published": return GitHubEvents.PackagePublished;
                }

                break;
            case "ping":
                if (action == null && payload.ContainsKey("hook")) { return GitHubEvents.WebhookPing; }

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
            case "issue_comment":
                switch (action)
                {
                    case "created": return GitHubEvents.IssueCommentCreated;
                    case "deleted": return GitHubEvents.IssueCommentDeleted;
                    case "edited": return GitHubEvents.IssueCommentEdited;
                }

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
            case "pull_request_review_comment":
                switch (action)
                {
                    case "created": return GitHubEvents.PullRequestCommentCreated;
                    case "deleted": return GitHubEvents.PullRequestCommentDeleted;
                    case "edited": return GitHubEvents.PullRequestCommentEdited;
                }

                break;
            case "pull_request_review_thread":
                switch (action)
                {
                    case "resolved": return GitHubEvents.PullRequestThreadResolved;
                }

                break;
            case "release":
                switch (action)
                {
                    case "created": return GitHubEvents.ReleaseCreated;
                    case "edited": return GitHubEvents.ReleaseEdited;
                    case "published": return GitHubEvents.ReleasePublished;
                    case "released": return GitHubEvents.ReleaseReleased;
                }

                break;
            case "sub_issues":
                switch (action)
                {
                    case "parent_issue_added": return GitHubEvents.SubIssuesParentIssueAdded;
                    case "sub_issue_added": return GitHubEvents.SubIssuesSubIssueAdded;
                }

                break;
        }

        // Fallback to old parsing logic
        return GitHubWebhookLegacy.GetEventType(action, payload, log);
    }
}
