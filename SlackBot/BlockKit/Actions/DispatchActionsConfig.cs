using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Actions
{
    public class DispatchActionsConfig
    {
        [JsonProperty("trigger_actions_on")]
        public string[] TriggersOn { get; set; }
    }
}