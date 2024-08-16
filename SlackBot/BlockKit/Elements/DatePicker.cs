using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Dialog;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class DatePicker : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.DatePicker;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("initial_date")]
        public string InitialDate { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}