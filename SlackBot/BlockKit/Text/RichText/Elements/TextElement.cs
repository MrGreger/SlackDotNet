using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class TextElementStyle
    {
        [JsonPropertyName("bold")]
        public bool Bold { get; set; }
        [JsonPropertyName("italic")]
        public bool Italic { get; set; }
        [JsonPropertyName("strike")]
        public bool Strike { get; set; }
        [JsonPropertyName("code")]
        public bool Code { get; set; }
    }
    
    public class TextElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Text;
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("style")]
        public TextElementStyle Style { get; set; }
    }
}