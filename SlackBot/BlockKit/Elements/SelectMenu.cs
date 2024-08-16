using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Elements
{
    public class SelectMenu : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.SelectMenu;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("options")]
        public List<InputOption> Options { get; set; } = new List<InputOption>();
        [JsonPropertyName("option_groups")]
        public List<InputOptionGroup> OptionGroups { get; set; } = new List<InputOptionGroup>();
        [JsonPropertyName("initial_option")]
        public IOptionPayload InitialOption { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}