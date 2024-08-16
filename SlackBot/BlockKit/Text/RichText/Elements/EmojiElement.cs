using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class EmojiElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Emoji;
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}