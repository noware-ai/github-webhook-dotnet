namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    BranchProtectionConfigurationEnabled,
    BranchProtectionConfigurationDisabled,

    BranchProtectionRuleCreated,
    BranchProtectionRuleDeleted,
    BranchProtectionRuleEdited,

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

    CommitCommentCreated,

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

    MemberAdded,
    MemberEdited,
    MemberRemoved,

    MembershipAdded,
    MembershipRemoved,

    MergeGroupChecksRequested,
    MergeGroupDestroyed,

    MilestoneClosed,
    MilestoneCreated,
    MilestoneDeleted,
    MilestoneEdited,
    MilestoneOpened,

    OrgBlockBlocked,
    OrgBlockUnblocked,

    OrganizationDeleted,
    OrganizationMemberAdded,
    OrganizationMemberInvited,
    OrganizationMemberRemoved,
    OrganizationRenamed,

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
    PullRequestThreadUnresolved,

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

    RepositoryVulnerabilityAlertCreate,
    RepositoryVulnerabilityAlertDismiss,
    RepositoryVulnerabilityAlertReopen,
    RepositoryVulnerabilityAlertResolve,

    SecretScanningAlertCreated,
    SecretScanningAlertPubliclyLeaked,
    SecretScanningAlertReopened,
    SecretScanningAlertResolved,
    SecretScanningAlertValidated,

    SecurityAdvisoryPublished,
    SecurityAdvisoryUpdated,
    SecurityAdvisoryWithdrawn,

    StarredAtCreated,
    StarredAtDeleted,

    SubIssuesParentIssueAdded,
    SubIssuesSubIssueAdded,

    TeamAddedToRepository,
    TeamCreated,
    TeamDeleted,
    TeamEdited,
    TeamRemovedToRepository,

    TeamAddEvent,

    WatchStarted,

    WorkflowJobCompleted,
    WorkflowJobInProgress,
    WorkflowJobQueued,
    WorkflowJobWaiting,

    WorkflowRunCompleted,
    WorkflowRunInProgress,
    WorkflowRunRequested,

    // Events without action
    CreateEvent,
    DeleteEvent,
    ForkEvent,
    PageBuildEvent,
    PushEvent,
    RepositoryVisibilityChangedToPublicEvent,
    SecretScanningAlertLocationEvent,
    SecurityAndAnalysisEvent,
    WebhookPingEvent,
    WorkflowCallEvent,
    WorkflowDispatchEvent,
}
