using System.Collections.Generic;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class RichTextListSectionStyle
    {
        public const string Bullet = "bullet";
        public const string Ordered = "ordered";
    }
    
    public class RichTextListSection : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.ListSection;
        [JsonProperty("elements")]
        public List<RichTextSection> Elements { get; set; } = new List<RichTextSection>();
        [JsonProperty("style")]
        public string Style { get; set; }    
        [JsonProperty("indent")]
        public int Indent { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("border")]
        public int Border { get; set; }
    }
}