using Newtonsoft.Json;

namespace SlackBot.Blocks
{
    public class UserGroupElementStyle
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
    
    public class UserGroupElement : RichTextElementBase
    {
        public override string Type => RichTextElementTypes.UserGroup;
        [JsonProperty("usergroup_id")]
        public string GroupId { get; set; }        
        [JsonProperty("style")]
        public UserGroupElementStyle Style { get; set; }
    }
}