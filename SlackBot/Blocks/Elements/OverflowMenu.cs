using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Checkbox;
using HttpSlackBot.Blocks.Dialog;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Elements
{
    public class OverflowMenu : ElementBase
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