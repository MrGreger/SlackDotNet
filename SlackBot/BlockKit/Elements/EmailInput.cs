using System.Text.Json.Serialization;
using SlackBot.Blocks.Actions;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks.Elements
{
    public class EmailInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.EmailInput;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("initial_value")]
        public string InitialValue { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
        [JsonPropertyName("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
    }
}