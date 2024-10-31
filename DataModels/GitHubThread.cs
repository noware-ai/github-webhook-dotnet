using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubThread
{
    [JsonPropertyName("comments")] public GitHubComment[]? Comments { get; set; }
}
