using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Dialog;
using HttpSlackBot.Blocks.Elements;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class DatePicker : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.DatePicker;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("initial_date")]
        public string InitialDate { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}