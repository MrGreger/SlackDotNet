using System.Text.Json.Serialization;

namespace SlackBot.Blocks.Dialog
{
    public class ConfirmationDialog
    {
        [JsonPropertyName("title")]
        public PlainText Title { get; set; }
        [JsonPropertyName("text")]
        public PlainText Text { get; set; }
        [JsonPropertyName("confirm")]
        public PlainText Confirm { get; set; }
        [JsonPropertyName("deny")]
        public PlainText Deny { get; set; }
        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}