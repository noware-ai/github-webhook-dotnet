using System.Text.Json;

namespace Noware.GitHub.Webhooks.Models;

public static class GitHubWebhook
{
    public static GitHubEvents GetEventType(string json)
    {
        Dictionary<string, JsonElement>? parse = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
        if (parse == null) { return GitHubEvents.Unknown; }

        string? action = null;
        if (parse.TryGetValue("action", out JsonElement jaction))
        {
            action = jaction.GetString();
        }

        switch (action)
        {
            case "answered":
                if (parse.ContainsKey("discussion")) { return GitHubEvents.DiscussionAnswered; }

                break;
            case "assigned":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueAssigned; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestAssigned; }

                break;
            case "auto_merge_enabled":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestAutoMergeEnabled; }

                break;
            case "checks_requested":
                if (parse.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupChecksRequested; }

                break;
            case "closed":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueClosed; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestClosed; }

                if (parse.ContainsKey("discussion")) { return GitHubEvents.DiscussionClosed; }

                break;
            case "completed":
                if (parse.ContainsKey("check_run")) { return GitHubEvents.CheckRunCompleted; }

                if (parse.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCompleted; }

                if (parse.ContainsKey("check_suite")) { return GitHubEvents.CheckSuiteCompleted; }

                if (parse.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobCompleted; }

                break;
            case "created":
                if (parse.ContainsKey("comment") && parse.ContainsKey("issue")) { return GitHubEvents.IssueCommentCreated; }

                if (parse.ContainsKey("comment") && parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestCommentCreated; }

                if (parse.ContainsKey("starred_at")) { return GitHubEvents.StarredAtCreated; }

                if (parse.ContainsKey("discussion")) { return GitHubEvents.DiscussionCreated; }

                if (parse.ContainsKey("release")) { return GitHubEvents.ReleaseCreated; }

                if (parse.ContainsKey("check_run")) { return GitHubEvents.CheckRunCreated; }

                if (parse.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCreated; }

                break;
            case "deleted":
                if (parse.ContainsKey("starred_at")) { return GitHubEvents.StarredAtDeleted; }

                break;
            case "dequeued":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestDequeued; }

                break;
            case "destroyed":
                if (parse.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupDestroyed; }

                break;
            case "edited":
                if (parse.ContainsKey("comment") && parse.ContainsKey("issue")) { return GitHubEvents.IssueCommentEdited; }

                if (parse.ContainsKey("comment") && parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestCommentEdited; }

                if (parse.ContainsKey("discussion")) { return GitHubEvents.DiscussionEdited; }

                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueEdited; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestEdited; }

                if (parse.ContainsKey("member") && parse.ContainsKey("changes")) { return GitHubEvents.RepoSettingsEdited; }

                break;
            case "enqueued":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestEnqueued; }

                break;
            case "fixed":
                if (parse.ContainsKey("alert")) { return GitHubEvents.AlertFixed; }

                break;
            case "in_progress":
                if (parse.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunInProgress; }

                if (parse.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobInProgress; }

                break;
            case "labeled":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueLabeled; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestLabeled; }

                break;
            case "opened":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueOpened; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestOpened; }

                break;
            case "published":
                if (parse.ContainsKey("registry_package")) { return GitHubEvents.RegistryPackagePublished; }

                if (parse.ContainsKey("package")) { return GitHubEvents.PackagePublished; }

                if (parse.ContainsKey("release")) { return GitHubEvents.ReleasePublished; }

                break;
            case "queued":
                if (parse.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobQueued; }

                break;
            case "ready_for_review":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestReadyForReview; }

                break;
            case "released":
                if (parse.ContainsKey("release")) { return GitHubEvents.ReleaseReleased; }

                break;
            case "requested":
                if (parse.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunRequested; }

                break;
            case "resolve":
                if (parse.ContainsKey("alert")) { return GitHubEvents.AlertResolve; }

                break;
            case "resolved":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestResolved; }

                break;
            case "review_requested":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestReviewRequested; }

                break;
            case "submitted":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestSubmitted; }

                break;
            case "started":
                if (parse.ContainsKey("sender")) { return GitHubEvents.LooksLikeRepoWatchCreated; }

                break;
            case "synchronize":
                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestSynchronize; }

                break;
            case "unassigned":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueUnassigned; }

                break;
            case "unlabeled":
                if (parse.ContainsKey("issue")) { return GitHubEvents.IssueUnlabeled; }

                if (parse.ContainsKey("pull_request")) { return GitHubEvents.PullRequestUnlabeled; }

                break;
            case "waiting":
                if (parse.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobWaiting; }

                break;
            default:
                if (parse.ContainsKey("ref")
                    && parse.ContainsKey("before")
                    && parse.ContainsKey("after")
                    && parse.ContainsKey("compare")
                    && parse.ContainsKey("pusher")
                    && parse.ContainsKey("sender")
                    && parse.ContainsKey("created")
                    && parse.ContainsKey("deleted")
                    && parse.ContainsKey("forced")
                   )
                {
                    return GitHubEvents.LooksLikeABranchPush;
                }

                if (parse.ContainsKey("ref")
                    && parse.ContainsKey("ref_type")
                    && parse.ContainsKey("sender")
                   )
                {
                    return GitHubEvents.LooksLikeAMergeFromQueue;
                }

                if (parse.ContainsKey("forkee"))
                {
                    return GitHubEvents.LooksLikeANewFork;
                }

                return GitHubEvents.Unknown;
        }

        return GitHubEvents.Unknown;
    }
}
