using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Checkbox;
using HttpSlackBot.Blocks.Dialog;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Elements
{
    public class RadioButtons : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.RadioButtons;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("options")]
        public InputOption[] Options { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog Confirmation { get; set; }
        [JsonProperty("initial_option")]
        public InputOption InitialOption { get; set; }        
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
    }
}