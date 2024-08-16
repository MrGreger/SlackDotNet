using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class UserElementStyle
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
    
    public class UserElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.User;
        public string UserId { get; set; }
        [JsonPropertyName("style")]
        public UserElementStyle Style { get; set; }
    }
}