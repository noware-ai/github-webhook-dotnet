namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    DiscussionAnswered,
    DiscussionClosed,
    DiscussionCommentCreated,
    DiscussionCommentDeleted,
    DiscussionCommentEdited,
    DiscussionCreated,
    DiscussionEdited,

    IssueAssigned,
    IssueClosed,
    IssueCommentCreated,
    IssueCommentDeleted,
    IssueCommentEdited,
    IssueEdited,
    IssueLabeled,
    IssueOpened,
    IssueTyped,
    IssueUnassigned,
    IssueUnlabeled,

    ParentIssueAdded,
    SubIssueAdded,

    PullRequestAssigned,
    PullRequestAutoMergeDisabled,
    PullRequestAutoMergeEnabled,
    PullRequestClosed,
    PullRequestCommentCreated,
    PullRequestCommentDeleted,
    PullRequestCommentEdited,
    PullRequestDequeued,
    PullRequestEdited,
    PullRequestEnqueued,
    PullRequestLabeled,
    PullRequestOpened,
    PullRequestReadyForReview,
    PullRequestResolved,
    PullRequestReviewRequested,
    PullRequestSubmitted,
    PullRequestSynchronize,
    PullRequestUnlabeled,

    MergeGroupChecksRequested,
    MergeGroupDestroyed,
    LooksLikeAMergeFromQueue,
    LooksLikeABranchPush,

    RegistryPackagePublished,
    PackagePublished,

    ReleaseCreated,
    ReleaseEdited,
    ReleasePublished,
    ReleaseReleased,

    AlertFixed,
    AlertReopened,
    AlertResolve,

    StarredAtCreated,
    StarredAtDeleted,
    LooksLikeRepoWatchCreated,
    LooksLikeANewFork,

    RepoSettingsEdited,
    LooksLikeAWebhookAction,
    WebhookPing,

    CheckSuiteCompleted,

    CheckRunCompleted,
    CheckRunCreated,

    WorkflowRunCompleted,
    WorkflowRunCreated,
    WorkflowRunInProgress,
    WorkflowRunRequested,

    WorkflowJobCompleted,
    WorkflowJobInProgress,
    WorkflowJobQueued,
    WorkflowJobWaiting,
}
