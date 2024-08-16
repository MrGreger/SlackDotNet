using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class LinkElementStyle
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
    
    public class LinkElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Link;
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("unsafe")]
        public bool Unsafe { get; set; }        
        [JsonPropertyName("style")]
        public LinkElementStyle Style { get; set; }
    }
}