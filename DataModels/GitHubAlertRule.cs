using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubAlertRule
{
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("full_description")] public string FullDescription { get; set; } = string.Empty;
    [JsonPropertyName("help")] public string Help { get; set; } = string.Empty;
    [JsonPropertyName("id")] public string Id { get; set; } = string.Empty; // e.g. "py/stack-trace-exposure"
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty; // e.g. "py/stack-trace-exposure"
    [JsonPropertyName("security_severity_level")] public string SecuritySeverityLevel { get; set; } = string.Empty; // e.g. "medium"
    [JsonPropertyName("severity")] public string Severity { get; set; } = string.Empty; // e.g. "error"
    [JsonPropertyName("tags")] public List<string> Tags { get; set; } = new(); // e.g. ["external/cwe/cwe-209", "security"]
}
