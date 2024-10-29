using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubTeam
{
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("notification_setting")] public string NotificationSetting { get; set; } = string.Empty; // e.g. "notifications_enabled"
    [JsonPropertyName("parent")] public object? Parent { get; set; } = null;
    [JsonPropertyName("permission")] public string Permission { get; set; } = string.Empty;
    [JsonPropertyName("privacy")] public string Privacy { get; set; } = string.Empty; // e.g. "closed"
    [JsonPropertyName("slug")] public string Slug { get; set; } = string.Empty;
}
