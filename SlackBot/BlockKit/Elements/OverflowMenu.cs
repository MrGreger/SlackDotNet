using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Dialog;
using SlackBotDotNet.BlockKit.Options;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class OverflowMenu : ElementBase, ISectionElement, IActionsElement
    {
        
        public class OverflowMenuOption
        {
            [JsonProperty("value")]
            public string Value
            {
                get;
                set;
            }
        }
        
        public override string Type => ElementTypes.OverflowMenu;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("options")]
        public InputOption[] Options { get; set; }
        [JsonProperty("confirm")]
        public ConfirmationDialog Confirmation { get; set; }
    }
}