using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Actions;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class PlainTextInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.PlainTextInput;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("multiline")]
        public bool Multiline { get; set; }
        [JsonProperty("initial_value")]
        public string InitialValue { get; set; }
        [JsonProperty("min_length")]
        public int MinLength { get; set; }
        [JsonProperty("max_length")]
        public int MaxLength { get; set; }
        [JsonProperty("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}