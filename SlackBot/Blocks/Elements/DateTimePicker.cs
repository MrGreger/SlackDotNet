using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Dialog;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Elements
{
    public class DateTimePicker : ElementBase, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.DateTimePicker;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("initial_date_time")]
        public long InitialDate { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
    }
}