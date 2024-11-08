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
    IssueReopened,
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

    PullRequestThreadResolved,

    PullRequestReviewSubmitted,

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

    CodeScanningAlertFixed,
    CodeScanningAlertResolve,
    CodeScanningAlertReopened,

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
