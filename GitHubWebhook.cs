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
            case "branch_protection_rule":
                switch (action)
                {
                    case "created": return GitHubEvents.BranchProtectionRuleCreated;
                }
                break;
            case "check_run":
                switch (action)
                {
                    case "completed": return GitHubEvents.CheckRunCompleted;
                    case "created": return GitHubEvents.CheckRunCreated;
                    case "requested_action": return GitHubEvents.CheckRunRequestedAction;
                    case "rerequested": return GitHubEvents.CheckRunRerequested;
                }

                break;
            case "check_suite":
                switch (action)
                {
                    case "completed": return GitHubEvents.CheckSuiteCompleted;
                }

                break;
            case "code_scanning_alert":
                switch (action)
                {
                    case "appeared_in_branch": return GitHubEvents.CodeScanningAlertAppearedInBranch;
                    case "closed_by_user": return GitHubEvents.CodeScanningAlertClosedByUser;
                    case "created": return GitHubEvents.CodeScanningAlertCreated;
                    case "fixed": return GitHubEvents.CodeScanningAlertFixed;
                    case "reopened": return GitHubEvents.CodeScanningAlertReopened;
                    case "reopened_by_user": return GitHubEvents.CodeScanningAlertReopenedByUser;
                    case "resolve": return GitHubEvents.CodeScanningAlertResolve;
                }

                break;
            case "create":
                // TODO
                break;
            case "delete":
                // TODO
                break;
            case "dependabot_alert":
                switch (action)
                {
                    case "auto_dismissed": return GitHubEvents.DependabotAlertAutoDismissed;
                    case "auto_reopened": return GitHubEvents.DependabotAlertAutoReopened;
                    case "created": return GitHubEvents.DependabotAlertCreated;
                    case "dismissed": return GitHubEvents.DependabotAlertDismissed;
                    case "fixed": return GitHubEvents.DependabotAlertFixed;
                    case "reintroduced": return GitHubEvents.DependabotAlertReintroduced;
                    case "reopened": return GitHubEvents.DependabotAlertReopened;
                }

                break;
            case "deployment":
                // TODO
                break;
            case "deployment_status":
                // TODO
                break;
            case "discussion":
                switch (action)
                {
                    case "answered": return GitHubEvents.DiscussionAnswered;
                    case "category_changed": return GitHubEvents.DiscussionCategoryChanged;
                    case "closed": return GitHubEvents.DiscussionClosed;
                    case "created": return GitHubEvents.DiscussionCreated;
                    case "deleted": return GitHubEvents.DiscussionDeleted;
                    case "edited": return GitHubEvents.DiscussionEdited;
                    case "labeled": return GitHubEvents.DiscussionLabeled;
                    case "locked": return GitHubEvents.DiscussionLocked;
                    case "pinned": return GitHubEvents.DiscussionPinned;
                    case "transferred": return GitHubEvents.DiscussionTransferred;
                    case "unanswered": return GitHubEvents.DiscussionUnanswered;
                    case "unlabeled": return GitHubEvents.DiscussionUnlabeled;
                    case "unlocked": return GitHubEvents.DiscussionUnlocked;
                    case "unpinned": return GitHubEvents.DiscussionUnpinned;
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
            case "fork":
                return GitHubEvents.RepositoryForkEvent;

            case "gollum":
                // TODO
                break;
            case "installation":
                // TODO
                break;
            case "installation_repositories":
                // TODO
                break;
            case "installation_target":
                // TODO
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
                    case "deleted": return GitHubEvents.IssueDeleted;
                    case "demilestoned": return GitHubEvents.IssueDemilestoned;
                    case "edited": return GitHubEvents.IssueEdited;
                    case "labeled": return GitHubEvents.IssueLabeled;
                    case "locked": return GitHubEvents.IssueLocked;
                    case "milestoned": return GitHubEvents.IssueMilestoned;
                    case "opened": return GitHubEvents.IssueOpened;
                    case "pinned": return GitHubEvents.IssuePinned;
                    case "reopened": return GitHubEvents.IssueReopened;
                    case "transferred": return GitHubEvents.IssueTransferred;
                    case "typed": return GitHubEvents.IssueTyped;
                    case "unassigned": return GitHubEvents.IssueUnassigned;
                    case "unlabeled": return GitHubEvents.IssueUnlabeled;
                    case "unlocked": return GitHubEvents.IssueUnlocked;
                    case "unpinned": return GitHubEvents.IssueUnpinned;
                }

                break;
            case "label":
                switch (action)
                {
                    case "created": return GitHubEvents.LabelCreated;
                    case "deleted": return GitHubEvents.LabelDeleted;
                    case "edited": return GitHubEvents.LabelEdited;
                }

                break;
            case "marketplace_purchase":
                // TODO
                break;
            case "merge_group":
                switch (action)
                {
                    case "checks_requested": return GitHubEvents.MergeGroupChecksRequested;
                    case "destroyed": return GitHubEvents.MergeGroupDestroyed;
                }

                break;
            case "meta":
                // TODO
                break;
            case "milesone":
                switch (action)
                {
                    case "closed": return GitHubEvents.MilestoneClosed;
                    case "created": return GitHubEvents.MilestoneCreated;
                    case "deleted": return GitHubEvents.MilestoneDeleted;
                    case "edited": return GitHubEvents.MilestoneEdited;
                    case "opened": return GitHubEvents.MilestoneOpened;
                }

                break;
            case "package":
                switch (action)
                {
                    case "published": return GitHubEvents.PackagePublished;
                    case "updated": return GitHubEvents.PackageUpdated;
                }

                break;
            case "page_build":
                // TODO
                break;
            case "ping":
                return GitHubEvents.WebhookPingEvent;
            case "public":
                return GitHubEvents.RepositoryVisibilityChangedToPublic;
            case "pull_request":
                switch (action)
                {
                    case "assigned": return GitHubEvents.PullRequestAssigned;
                    case "auto_merge_disable": return GitHubEvents.PullRequestAutoMergeDisable;
                    case "auto_merge_disabled": return GitHubEvents.PullRequestAutoMergeDisabled;
                    case "auto_merge_enabled": return GitHubEvents.PullRequestAutoMergeEnabled;
                    case "closed": return GitHubEvents.PullRequestClosed;
                    case "converted_to_draft": return GitHubEvents.PullRequestConvertedToDraft;
                    case "demilestoned": return GitHubEvents.PullRequestDemilestoned;
                    case "dequeued": return GitHubEvents.PullRequestDequeued;
                    case "edited": return GitHubEvents.PullRequestEdited;
                    case "enqueued": return GitHubEvents.PullRequestEnqueued;
                    case "labeled": return GitHubEvents.PullRequestLabeled;
                    case "locked": return GitHubEvents.PullRequestLocked;
                    case "milestoned": return GitHubEvents.PullRequestMilestoned;
                    case "opened": return GitHubEvents.PullRequestOpened;
                    case "ready_for_review": return GitHubEvents.PullRequestReadyForReview;
                    case "reopened": return GitHubEvents.PullRequestReopened;
                    case "resolved": return GitHubEvents.PullRequestResolved;
                    case "review_request_removed": return GitHubEvents.PullRequestReviewRequestRemoved;
                    case "review_requested": return GitHubEvents.PullRequestReviewRequested;
                    case "submitted": return GitHubEvents.PullRequestSubmitted;
                    case "synchronize": return GitHubEvents.PullRequestSynchronize;
                    case "unassigned": return GitHubEvents.PullRequestUnassigned;
                    case "unlabeled": return GitHubEvents.PullRequestUnlabeled;
                    case "unlocked": return GitHubEvents.PullRequestUnlocked;
                }

                break;
            case "pull_request_review":
                switch (action)
                {
                    case "dismissed": return GitHubEvents.PullRequestReviewDismissed;
                    case "edited": return GitHubEvents.PullRequestReviewEdited;
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
            case "pull_request_target":
                // TODO
                break;
            case "push":
                // TODO
                break;
            case "registry_package":
                switch (action)
                {
                    case "published": return GitHubEvents.RegistryPackagePublished;
                    case "updated": return GitHubEvents.RegistryPackageUpdated;
                }

                break;
            case "release":
                switch (action)
                {
                    case "created": return GitHubEvents.ReleaseCreated;
                    case "deleted": return GitHubEvents.ReleaseDeleted;
                    case "edited": return GitHubEvents.ReleaseEdited;
                    case "prereleased": return GitHubEvents.ReleasePrereleased;
                    case "published": return GitHubEvents.ReleasePublished;
                    case "released": return GitHubEvents.ReleaseReleased;
                    case "unpublished": return GitHubEvents.ReleaseUnpublished;
                }

                break;
            case "repository_dispatch":
                // TODO
                break;
            case "schedule":
                // TODO
                break;
            case "star":
                switch (action)
                {
                    case "created": return GitHubEvents.StarredAtCreated;
                    case "deleted": return GitHubEvents.StarredAtDeleted;
                }

                break;
            case "status":
                // TODO
                break;
            case "sub_issues":
                switch (action)
                {
                    case "parent_issue_added": return GitHubEvents.SubIssuesParentIssueAdded;
                    case "sub_issue_added": return GitHubEvents.SubIssuesSubIssueAdded;
                }

                break;
            case "watch":
                switch (action)
                {
                    case "started": return GitHubEvents.WatchStarted;
                }

                break;
            case "workflow_call":
                return GitHubEvents.WorkflowCallEvent;

            case "workflow_dispatch":
                return GitHubEvents.WorkflowDispatchEvent;

            case "workflow_run":
                switch (action)
                {
                    case "completed": return GitHubEvents.WorkflowRunCompleted;
                    case "in_progress": return GitHubEvents.WorkflowRunInProgress;
                    case "requested": return GitHubEvents.WorkflowRunRequested;
                }

                break;
        }

        return GitHubEvents.Unknown;
    }
}
