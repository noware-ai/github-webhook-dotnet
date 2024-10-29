using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubUser
{
    [JsonPropertyName("avatar_url")] public string AvatarUrl { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("login")] public string Login { get; set; } = string.Empty;
    [JsonPropertyName("site_admin")] public bool SiteAdmin { get; set; }
    [JsonPropertyName("type")] public string Type { get; set; } = string.Empty; // "User" | "Bot"
    [JsonPropertyName("user_view_type")] public string UserViewType { get; set; } = string.Empty; // "public"
}
