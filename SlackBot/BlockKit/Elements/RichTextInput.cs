using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Actions;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
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