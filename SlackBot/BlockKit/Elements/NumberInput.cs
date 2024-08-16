using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Actions;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class NumberInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.NumberInput;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("is_decimal_allowed")]
        public bool AllowDecimal { get; set; }
        [JsonProperty("initial_value")]
        public string InitialValue { get; set; }
        [JsonProperty("min_value")]
        public string MinValue { get; set; }
        [JsonProperty("max_value")]
        public string MaxValue { get; set; }
        [JsonProperty("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}