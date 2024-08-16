using Newtonsoft.Json;
using SlackBot.Blocks.Actions;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks.Elements
{
    public class UrlInputElement : ElementBase, IInputElement
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