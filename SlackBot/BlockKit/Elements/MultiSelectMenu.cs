using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Dialog;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class MultiSelectMenu : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.MultiSelectMenu;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("options")]
        public IList<InputOption> Options { get; set; }
        [JsonPropertyName("option_groups")]
        public IList<InputOptionGroup> OptionGroups { get; set; }
        [JsonPropertyName("initial_option")]
        public InputOption InitialOption { get; set; }
        [JsonPropertyName("initial_option")]
        public InputOptionGroup InitialOptionGroup { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}