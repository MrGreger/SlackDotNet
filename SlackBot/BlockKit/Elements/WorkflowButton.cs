using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks.Elements
{
    public class WorkflowButton : ElementBase, ISectionElement, IActionsElement
    {
        public class Styles
        {
            public const string Primary = "primary";
            public const string Danger = "danger";
        }
        
        public override string Type => ElementTypes.WorkflowButton;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("text")]
        public PlainText Text { get; set; }
        [JsonPropertyName("workflow")]
        public Workflow Workflow { get; set; }
        [JsonPropertyName("style")]
        public string Style { get; set; }
        [JsonPropertyName("accessibility_label")]
        public string AccessibilityLabel { get; set; }
    }
}