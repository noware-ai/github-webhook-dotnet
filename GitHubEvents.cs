namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    DiscussionAnswered,
    DiscussionClosed,
    DiscussionCreated,
    DiscussionEdited,
    DiscussionLabeled,

    DiscussionCommentCreated,
    DiscussionCommentDeleted,
    DiscussionCommentEdited,

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

    SubIssuesParentIssueAdded,
    SubIssuesSubIssueAdded,

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
