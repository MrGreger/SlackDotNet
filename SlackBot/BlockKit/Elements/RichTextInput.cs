using System.Text.Json.Serialization;
using SlackBot.Blocks.Actions;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Builders
{
    public class RichTextInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.RichTextInput;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("initial_value")]
        public Blocks.RichTextBlock InitialValue { get; set; }
        [JsonPropertyName("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}