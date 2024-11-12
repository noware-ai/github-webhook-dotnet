namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    BranchProtectionRuleCreated,

    CheckRunCompleted,
    CheckRunCreated,
    CheckRunRequestedAction,
    CheckRunRerequested,

    CheckSuiteCompleted,

    CodeScanningAlertAppearedInBranch,
    CodeScanningAlertClosedByUser,
    CodeScanningAlertCreated,
    CodeScanningAlertFixed,
    CodeScanningAlertReopened,
    CodeScanningAlertReopenedByUser,
    CodeScanningAlertResolve,

    DependabotAlertAutoDismissed,
    DependabotAlertAutoReopened,
    DependabotAlertCreated,
    DependabotAlertDismissed,
    DependabotAlertFixed,
    DependabotAlertReintroduced,
    DependabotAlertReopened,

    DeploymentCreated,

    DeploymentStatusCreated,

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

    MergeGroupChecksRequested,
    MergeGroupDestroyed,

    MilestoneClosed,
    MilestoneCreated,
    MilestoneDeleted,
    MilestoneEdited,
    MilestoneOpened,

    PackagePublished,
    PackageUpdated,

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

    RegistryPackagePublished,
    RegistryPackageUpdated,

    ReleaseCreated,
    ReleaseDeleted,
    ReleaseEdited,
    ReleasePrereleased,
    ReleasePublished,
    ReleaseReleased,
    ReleaseUnpublished,

    StarredAtCreated,
    StarredAtDeleted,

    SubIssuesParentIssueAdded,
    SubIssuesSubIssueAdded,

    WatchStarted,

    WorkflowRunCompleted,
    WorkflowRunInProgress,
    WorkflowRunRequested,

    // Events without action
    CreateEvent,
    DeleteEvent,
    ForkEvent,
    PushEvent,
    RepositoryVisibilityChangedToPublicEvent,
    WebhookPingEvent,
    WorkflowCallEvent,
    WorkflowDispatchEvent,

    // WorkflowJobCompleted,
    // WorkflowJobInProgress,
    // WorkflowJobQueued,
    // WorkflowJobWaiting,

    // RepoSettingsEdited,
}
