using HttpSlackBot.Blocks.Actions;
using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Elements;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Builders
{
    public class RichTextInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.RichTextInput;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("initial_value")]
        public Blocks.RichTextBlock InitialValue { get; set; }
        [JsonProperty("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}