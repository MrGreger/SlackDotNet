using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpSlackBot.Blocks.Dialog;
using HttpSlackBot.Blocks.Elements;

namespace HttpSlackBot.Blocks.Checkbox
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