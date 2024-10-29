using Noware.GitHub.Webhooks.Models.DataModels;

namespace Noware.GitHub.Webhooks.Models.EventModels;

public class PullRequestResolved
{
    public GitHubEnterprise Enterprise { get; set; } = new();
    public GitHubOrganization Organization { get; set; } = new();
    public GitHubPullRequest PullRequest { get; set; } = new();
    public GitHubRepository Repository { get; set; } = new();
    public GitHubUser Sender { get; set; } = new();
}

public static partial class GitHubWebhookPayloadExtensions
{
    public static PullRequestResolved AsPullRequestResolved(this GitHubWebhookPayload data)
    {
        return new PullRequestResolved
        {
            Enterprise = data.Enterprise ?? new GitHubEnterprise(),
            Organization = data.Organization ?? new GitHubOrganization(),
            PullRequest = data.PullRequest ?? new GitHubPullRequest(),
            Repository = data.Repository ?? new GitHubRepository(),
            Sender = data.Sender ?? new GitHubUser(),
        };
    }
}
