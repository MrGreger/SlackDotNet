using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Elements
{
    public class TimePicker : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.TimePicker;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("initial_value")]
        public string InitialValue { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}