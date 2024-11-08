using System.Text.Json;

namespace Noware.GitHub.Webhooks.Models;

public static partial class GitHubWebhook
{
    public static GitHubEvents GetEventTypeV2(string gitHubEventName, string json)
    {
        Dictionary<string, JsonElement>? parse = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
        if (parse == null) { return GitHubEvents.Unknown; }

        string? action = null;
        if (parse.TryGetValue("action", out JsonElement jaction))
        {
            action = jaction.GetString();
        }

        switch (gitHubEventName)
        {
            case "ping":
                if (parse.ContainsKey("hook"))
                {
                    return GitHubEvents.WebhookPing;
                }
                break;
            default:
                return GitHubEvents.Unknown;
        }

        return GitHubEvents.Unknown;
    }
}
