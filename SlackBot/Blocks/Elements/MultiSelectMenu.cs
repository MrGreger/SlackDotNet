using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Checkbox;
using HttpSlackBot.Blocks.Dialog;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class MultiSelectMenu : ElementBase
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