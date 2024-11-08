using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace Noware.GitHub.Webhooks.Models;

internal static class GitHubWebhookLegacy
{
    internal static GitHubEvents GetEventType(string? action, Dictionary<string, JsonElement> payload, ILogger log)
    {
        switch (action)
        {
            case "checks_requested":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupChecksRequested; }

                break;
            case "completed":
                if (payload.ContainsKey("check_run")) { return GitHubEvents.CheckRunCompleted; }

                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCompleted; }

                if (payload.ContainsKey("check_suite")) { return GitHubEvents.CheckSuiteCompleted; }

                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobCompleted; }

                break;
            case "created":
                if (payload.ContainsKey("check_run")) { return GitHubEvents.CheckRunCreated; }

                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunCreated; }

                break;
            case "destroyed":
                if (payload.ContainsKey("merge_group")) { return GitHubEvents.MergeGroupDestroyed; }

                break;
            case "edited":
                if (payload.ContainsKey("member") && payload.ContainsKey("changes")) { return GitHubEvents.RepoSettingsEdited; }

                break;
            case "in_progress":
                if (payload.ContainsKey("workflow_run")) { return GitHubEvents.WorkflowRunInProgress; }

                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobInProgress; }

                break;
            case "queued":
                if (payload.ContainsKey("workflow_job")) { return GitHubEvents.WorkflowJobQueued; }

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
