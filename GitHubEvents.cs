namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    DiscussionCategoryChanged,
    DiscussionAnswered,
    DiscussionClosed,
    DiscussionCreated,
    DiscussionDeleted,
    DiscussionEdited,
    DiscussionLabeled,
    DiscussionLocked,
    DiscussionPinned,
    DiscussionTransferred,
    DiscussionUnanswered,
    DiscussionUnlabeled,
    DiscussionUnlocked,
    DiscussionUnpinned,

    DiscussionCommentCreated,
    DiscussionCommentDeleted,
    DiscussionCommentEdited,

    IssueAssigned,
    IssueClosed,
    IssueDeleted,
    IssueDemilestoned,
    IssueEdited,
    IssueLabeled,
    IssueLocked,
    IssueMilestoned,
    IssueOpened,
    IssuePinned,
    IssueReopened,
    IssueTransferred,
    IssueTyped,
    IssueUnassigned,
    IssueUnlabeled,
    IssueUnlocked,
    IssueUnpinned,

    IssueCommentCreated,
    IssueCommentDeleted,
    IssueCommentEdited,

    LabelCreated,
    LabelDeleted,
    LabelEdited,

    MilestoneClosed,
    MilestoneCreated,
    MilestoneDeleted,
    MilestoneEdited,
    MilestoneOpened,

    SubIssuesParentIssueAdded,
    SubIssuesSubIssueAdded,

    PullRequestAssigned,
    PullRequestAutoMergeDisable,
    PullRequestAutoMergeDisabled,
    PullRequestAutoMergeEnabled,
    PullRequestClosed,
    PullRequestConvertedToDraft,
    PullRequestDemilestoned,
    PullRequestDequeued,
    PullRequestEdited,
    PullRequestEnqueued,
    PullRequestLabeled,
    PullRequestLocked,
    PullRequestMilestoned,
    PullRequestOpened,
    PullRequestReadyForReview,
    PullRequestReopened,
    PullRequestResolved,
    PullRequestReviewRequestRemoved,
    PullRequestReviewRequested,
    PullRequestSubmitted,
    PullRequestSynchronize,
    PullRequestUnassigned,
    PullRequestUnlabeled,
    PullRequestUnlocked,

    PullRequestCommentCreated,
    PullRequestCommentDeleted,
    PullRequestCommentEdited,

    PullRequestThreadResolved,

    PullRequestReviewDismissed,
    PullRequestReviewEdited,
    PullRequestReviewSubmitted,

    MergeGroupChecksRequested,
    MergeGroupDestroyed,

    RegistryPackagePublished,
    RegistryPackageUpdated,

    PackagePublished,

    ReleaseCreated,
    ReleaseDeleted,
    ReleaseEdited,
    ReleasePrereleased,
    ReleasePublished,
    ReleaseReleased,
    ReleaseUnpublished,

    CodeScanningAlertFixed,
    CodeScanningAlertResolve,
    CodeScanningAlertReopened,

    StarredAtCreated,
    StarredAtDeleted,

    WatchStarted,

    WebhookPing,

    CheckSuiteCompleted,

    CheckRunCompleted,
    CheckRunCreated,
    CheckRunRequestedAction,
    CheckRunRerequested,

    WorkflowRunCompleted,
    WorkflowRunInProgress,
    WorkflowRunRequested,

    // Events without action
    WorkflowDispatchEvent,
    WorkflowCallEvent,
    RepositoryForkEvent,

    // WorkflowJobCompleted,
    // WorkflowJobInProgress,
    // WorkflowJobQueued,
    // WorkflowJobWaiting,

    // RepoSettingsEdited,
}
