using HttpSlackBot.Blocks.Actions;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Elements
{
    public class UrlInputElement : ElementBase
    {
        public override string Type => ElementTypes.UrlInput;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("initial_value")]
        public string InitialValue { get; set; }
        [JsonProperty("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}