using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Elements
{
    public class DateTimePicker : ElementBase, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.DateTimePicker;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("initial_date_time")]
        public long InitialDate { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
    }
}