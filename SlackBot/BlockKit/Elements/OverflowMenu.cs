using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Elements
{
    public class OverflowMenu : ElementBase, ISectionElement, IActionsElement
    {
        
        public class OverflowMenuOption
        {
            [JsonPropertyName("value")]
            public string Value
            {
                get;
                set;
            }
        }
        
        public override string Type => ElementTypes.OverflowMenu;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("options")]
        public InputOption[] Options { get; set; }
        [JsonPropertyName("confirm")]
        public ConfirmationDialog Confirmation { get; set; }
    }
}