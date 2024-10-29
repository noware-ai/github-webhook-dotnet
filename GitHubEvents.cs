namespace Noware.GitHub.Webhooks.Models;

public enum GitHubEvents
{
    Unknown = -1,

    DiscussionCreated,
    DiscussionEdited,
    DiscussionAnswered,
    DiscussionClosed,

    IssueOpened,
    IssueEdited,
    IssueUnassigned,
    IssueLabeled,
    IssueUnlabeled,
    IssueAssigned,
    IssueCommentCreated,
    IssueCommentEdited,
    IssueClosed,

    PullRequestOpened,
    PullRequestEdited,
    PullRequestLabeled,
    PullRequestUnlabeled,
    PullRequestReadyForReview,
    PullRequestReviewRequested,
    PullRequestAssigned,
    PullRequestSynchronize,
    PullRequestCommentCreated,
    PullRequestCommentEdited,
    PullRequestEnqueued,
    PullRequestDequeued,
    PullRequestSubmitted,
    PullRequestResolved,
    PullRequestAutoMergeEnabled,
    PullRequestClosed,

    MergeGroupChecksRequested,
    MergeGroupDestroyed,
    LooksLikeAMergeFromQueue,
    LooksLikeABranchPush,

    RegistryPackagePublished,
    PackagePublished,

    ReleaseCreated,
    ReleaseReleased,
    ReleasePublished,

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

    WorkflowRunRequested,
    WorkflowRunCreated,
    WorkflowRunInProgress,
    WorkflowRunCompleted,

    WorkflowJobQueued,
    WorkflowJobInProgress,
    WorkflowJobWaiting,
    WorkflowJobCompleted,
}
