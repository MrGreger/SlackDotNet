using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;
using SlackBotDotNet.BlockKit.Options;

namespace SlackBotDotNet.BlockKit.Elements
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