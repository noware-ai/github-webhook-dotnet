using Noware.GitHub.Webhooks.Models.DataModels;

namespace Noware.GitHub.Webhooks.Models.EventModels;

public class PullRequestClosed
{
    public GitHubEnterprise Enterprise { get; set; } = new();
    public GitHubOrganization Organization { get; set; } = new();
    public GitHubPullRequest PullRequest { get; set; } = new();
    public GitHubRepository Repository { get; set; } = new();
    public GitHubUser Sender { get; set; } = new();
}

public static partial class GitHubWebhookPayloadExtensions
{
    public static PullRequestClosed AsPullRequestClosed(this GitHubWebhookPayload data)
    {
        return new PullRequestClosed
        {
            Enterprise = data.Enterprise ?? new GitHubEnterprise(),
            Organization = data.Organization ?? new GitHubOrganization(),
            PullRequest = data.PullRequest ?? new GitHubPullRequest(),
            Repository = data.Repository ?? new GitHubRepository(),
            Sender = data.Sender ?? new GitHubUser(),
        };
    }
}
