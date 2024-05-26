using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Elements
{
    public class WorkflowButton : ElementBase
    {
        public class Styles
        {
            public const string Primary = "primary";
            public const string Danger = "danger";
        }
        
        public override string Type => ElementTypes.WorkflowButton;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("text")]
        public PlainText Text { get; set; }
        [JsonProperty("workflow")]
        public Workflow Workflow { get; set; }
        [JsonProperty("style")]
        public string Style { get; set; }
        [JsonProperty("accessibility_label")]
        public string AccessibilityLabel { get; set; }
    }
}