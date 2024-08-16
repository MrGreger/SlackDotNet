using System.Text.Json.Serialization;
using SlackBot.Blocks.Actions;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Builders
{
    public class NumberInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.NumberInput;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("is_decimal_allowed")]
        public bool AllowDecimal { get; set; }
        [JsonPropertyName("initial_value")]
        public string InitialValue { get; set; }
        [JsonPropertyName("min_value")]
        public string MinValue { get; set; }
        [JsonPropertyName("max_value")]
        public string MaxValue { get; set; }
        [JsonPropertyName("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}