using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Elements
{
    public class RadioButtons : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.RadioButtons;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("options")]
        public InputOption[] Options { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog Confirmation { get; set; }
        [JsonPropertyName("initial_option")]
        public InputOption InitialOption { get; set; }        
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
    }
}