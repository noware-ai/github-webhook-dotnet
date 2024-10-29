using Noware.GitHub.Webhooks.Models.DataModels;

namespace Noware.GitHub.Webhooks.Models.EventModels;

public class DiscussionClosed
{
    public GitHubDiscussion Discussion { get; set; } = new();
    public GitHubEnterprise Enterprise { get; set; } = new();
    public GitHubOrganization Organization { get; set; } = new();
    public GitHubRepository Repository { get; set; } = new();
    public GitHubUser Sender { get; set; } = new();
}

public static partial class GitHubWebhookPayloadExtensions
{
    public static DiscussionClosed AsDiscussionClosed(this GitHubWebhookPayload data)
    {
        return new DiscussionClosed
        {
            Discussion = data.Discussion ?? new GitHubDiscussion(),
            Enterprise = data.Enterprise ?? new GitHubEnterprise(),
            Organization = data.Organization ?? new GitHubOrganization(),
            Repository = data.Repository ?? new GitHubRepository(),
            Sender = data.Sender ?? new GitHubUser(),
        };
    }
}
