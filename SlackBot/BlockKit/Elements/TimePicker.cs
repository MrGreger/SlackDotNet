using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class TimePicker : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.TimePicker;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("initial_value")]
        public string InitialValue { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}