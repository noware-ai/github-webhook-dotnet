using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubCommit
{
    [JsonPropertyName("author")] public GitUser? Author { get; set; }
    [JsonPropertyName("committer")] public GitUser? Committer { get; set; }
    [JsonPropertyName("id")] public string Id { get; set; } = string.Empty;
    [JsonPropertyName("message")] public string Message { get; set; } = string.Empty;
    [JsonPropertyName("timestamp")] public DateTimeOffset Timestamp { get; set; }
    [JsonPropertyName("tree_id")] public string TreeId { get; set; } = string.Empty;
}
