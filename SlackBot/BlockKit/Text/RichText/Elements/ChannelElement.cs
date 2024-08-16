using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class ChannelElementStyle
    {
        [JsonPropertyName("bold")]
        public bool Bold { get; set; }
        [JsonPropertyName("italic")]
        public bool Italic { get; set; }
        [JsonPropertyName("strike")]
        public bool Strike { get; set; }
        [JsonPropertyName("highlight")]
        public bool Highlight { get; set; }
        [JsonPropertyName("client_highlight")]
        public bool ClientHighlight { get; set; }
        [JsonPropertyName("unlink")]
        public bool Unlink { get; set; }
    }
    
    public class ChannelElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.Channel;
        [JsonPropertyName("channel_id")]
        public string Channel { get; set; }        
        [JsonPropertyName("style")]
        public ChannelElementStyle Style { get; set; }
    }
}