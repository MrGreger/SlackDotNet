using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;

namespace SlackBotDotNet.BlockKit.Elements
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