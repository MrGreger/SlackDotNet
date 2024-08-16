using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Text.RichText.Elements
{
    public class EmojiElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Emoji;
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}