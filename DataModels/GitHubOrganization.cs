using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubOrganization
{
    [JsonPropertyName("avatar_url")] public string AvatarUrl { get; set; } = string.Empty;
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("login")] public string Login { get; set; } = string.Empty;
}
