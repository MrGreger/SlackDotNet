using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Text.RichText.Elements
{
    public class ChannelElementStyle
    {
        [JsonProperty("bold")]
        public bool Bold { get; set; }
        [JsonProperty("italic")]
        public bool Italic { get; set; }
        [JsonProperty("strike")]
        public bool Strike { get; set; }
        [JsonProperty("highlight")]
        public bool Highlight { get; set; }
        [JsonProperty("client_highlight")]
        public bool ClientHighlight { get; set; }
        [JsonProperty("unlink")]
        public bool Unlink { get; set; }
    }
    
    public class ChannelElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Channel;
        [JsonProperty("channel_id")]
        public string Channel { get; set; }        
        [JsonProperty("style")]
        public ChannelElementStyle Style { get; set; }
    }
}