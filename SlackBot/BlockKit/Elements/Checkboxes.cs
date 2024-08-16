using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Dialog;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Checkbox
{
    public class Checkboxes : ElementBase, ISectionElement, IActionsElement, IInputElement
    {
        public override string Type => ElementTypes.CheckBoxes;
        [JsonPropertyName("options")]
        public IList<InputOption> Options { get; set; }
        [JsonPropertyName("initial_options")]
        public IList<InputOption> InitialOptions { get; set; }
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog ConfirmationDialog { get; set; }
    }
}