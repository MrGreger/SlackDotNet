using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;
using SlackBotDotNet.BlockKit.Options;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class SelectMenu : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.SelectMenu;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("options")]
        public List<InputOption> Options { get; set; } = new List<InputOption>();
        [JsonProperty("option_groups")]
        public List<InputOptionGroup> OptionGroups { get; set; } = new List<InputOptionGroup>();
        [JsonProperty("initial_option")]
        public IOptionPayload InitialOption { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}