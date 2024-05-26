using HttpSlackBot.Blocks.Actions;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Builders
{
    public class NumberInput : ElementBase
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