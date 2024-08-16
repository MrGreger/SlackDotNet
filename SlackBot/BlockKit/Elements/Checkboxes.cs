using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;
using SlackBotDotNet.BlockKit.Options;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class Checkboxes : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.CheckBoxes;
        [JsonProperty("options")]
        public IList<InputOption> Options { get; set; }
        [JsonProperty("initial_options")]
        public IList<InputOption> InitialOptions { get; set; }
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
    }
}