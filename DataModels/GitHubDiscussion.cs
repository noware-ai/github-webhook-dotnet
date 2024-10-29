using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubDiscussion
{
    [JsonPropertyName("answer_chosen_at")] public DateTimeOffset? AnswerChosenAt { get; set; }
    [JsonPropertyName("answer_chosen_by")] public GitHubUser? AnswerChosenBy { get; set; }
    [JsonPropertyName("answer_html_url")] public string AnswerHtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("category")] public GitHubDiscussionCategory? Category { get; set; } = null;
    [JsonPropertyName("comments")] public int Comments { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("labels")] public object[]? Labels { get; set; }
    [JsonPropertyName("locked")] public bool Locked { get; set; }
    [JsonPropertyName("number")] public long Number { get; set; }
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty;
    [JsonPropertyName("state_reason")] public string StateReason { get; set; } = string.Empty;
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonPropertyName("user")] public GitHubUser? User { get; set; }
}
