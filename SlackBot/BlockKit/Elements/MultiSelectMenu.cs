using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Dialog;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class MultiSelectMenu : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.MultiSelectMenu;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("options")]
        public IList<InputOption> Options { get; set; }
        [JsonProperty("option_groups")]
        public IList<InputOptionGroup> OptionGroups { get; set; }
        [JsonProperty("initial_option")]
        public InputOption InitialOption { get; set; }
        [JsonProperty("initial_option")]
        public InputOptionGroup InitialOptionGroup { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}