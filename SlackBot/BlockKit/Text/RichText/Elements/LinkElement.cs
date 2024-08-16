using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Text.RichText.Elements
{
    public class LinkElementStyle
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
    
    public class LinkElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Link;
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("unsafe")]
        public bool Unsafe { get; set; }        
        [JsonProperty("style")]
        public LinkElementStyle Style { get; set; }
    }
}