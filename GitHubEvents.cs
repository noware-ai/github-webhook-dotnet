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
    ReleasePublished,
    ReleaseReleased,

    AlertFixed,
    AlertResolve,

    StarredAtCreated,
    StarredAtDeleted,
    LooksLikeRepoWatchCreated,
    LooksLikeANewFork,

    RepoSettingsEdited,

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
