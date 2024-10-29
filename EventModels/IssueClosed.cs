using Noware.GitHub.Webhooks.Models.DataModels;

namespace Noware.GitHub.Webhooks.Models.EventModels;

public class IssueClosed
{
    public GitHubEnterprise Enterprise { get; set; } = new();
    public GitHubIssue Issue { get; set; } = new();
    public GitHubOrganization Organization { get; set; } = new();
    public GitHubRepository Repository { get; set; } = new();
    public GitHubUser Sender { get; set; } = new();
}

public static partial class GitHubWebhookPayloadExtensions
{
    public static IssueClosed AsIssueClosed(this GitHubWebhookPayload data)
    {
        return new IssueClosed
        {
            Enterprise = data.Enterprise ?? new GitHubEnterprise(),
            Issue = data.Issue ?? new GitHubIssue(),
            Organization = data.Organization ?? new GitHubOrganization(),
            Repository = data.Repository ?? new GitHubRepository(),
            Sender = data.Sender ?? new GitHubUser(),
        };
    }
}

