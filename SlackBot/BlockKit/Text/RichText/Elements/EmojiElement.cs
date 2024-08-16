using Newtonsoft.Json;

namespace SlackBot.Blocks
{
    public class EmojiElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Emoji;
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}