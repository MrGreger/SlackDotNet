using System.Text.Json.Serialization;

namespace SlackBot.Blocks.Actions
{
    public class DispatchActionsConfig
    {
        [JsonPropertyName("trigger_actions_on")]
        public string[] TriggersOn { get; set; }
    }
}