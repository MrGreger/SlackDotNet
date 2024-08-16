using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class Button : ElementBase, ISectionElement, IActionsElement
    {
        public class Styles
        {
            public const string Primary = "primary";
            public const string Danger = "danger";
        }

        public override string Type => ElementTypes.Button;
        [JsonProperty("text")]
        public PlainText Content { get; set; }
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("style")]
        public string Style { get; set; }
        [JsonProperty("accessibility_label")]
        public string AccessibilityLabel { get; set; }
    }
}
