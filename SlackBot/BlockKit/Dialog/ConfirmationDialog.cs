using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Dialog
{
    public class ConfirmationDialog
    {
        [JsonProperty("title")]
        public PlainText Title { get; set; }
        [JsonProperty("text")]
        public PlainText Text { get; set; }
        [JsonProperty("confirm")]
        public PlainText Confirm { get; set; }
        [JsonProperty("deny")]
        public PlainText Deny { get; set; }
        [JsonProperty("style")]
        public string Style { get; set; }
    }
}