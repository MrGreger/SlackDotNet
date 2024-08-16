using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class UserElementStyle
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
    
    public class UserElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.User;
        public string UserId { get; set; }
        [JsonProperty("style")]
        public UserElementStyle Style { get; set; }
    }
}