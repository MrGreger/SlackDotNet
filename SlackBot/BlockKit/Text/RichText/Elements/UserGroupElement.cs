using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class UserGroupElementStyle
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
    
    public class UserGroupElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.UserGroup;
        [JsonPropertyName("usergroup_id")]
        public string GroupId { get; set; }        
        [JsonPropertyName("style")]
        public UserGroupElementStyle Style { get; set; }
    }
}