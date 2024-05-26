using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class TextElementStyle
    {
        [JsonProperty("bold")]
        public bool Bold { get; set; }
        [JsonProperty("italic")]
        public bool Italic { get; set; }
        [JsonProperty("strike")]
        public bool Strike { get; set; }
        [JsonProperty("code")]
        public bool Code { get; set; }
    }
    
    public class TextElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Text;
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("style")]
        public TextElementStyle Style { get; set; }
    }
}