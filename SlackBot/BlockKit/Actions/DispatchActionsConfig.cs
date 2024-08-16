using Newtonsoft.Json;

namespace SlackBot.Blocks.Actions
{
    public class DispatchActionsConfig
    {
        [JsonProperty("trigger_actions_on")]
        public string[] TriggersOn { get; set; }
    }
}