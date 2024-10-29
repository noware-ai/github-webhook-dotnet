using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubChanges
{
    [JsonPropertyName("permission")] public object? Permission { get; set; } = null;
}
