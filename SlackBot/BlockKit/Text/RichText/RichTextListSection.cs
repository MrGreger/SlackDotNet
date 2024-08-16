using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class RichTextListSectionStyle
    {
        public const string Bullet = "bullet";
        public const string Ordered = "ordered";
    }
    
    public class RichTextListSection : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.ListSection;
        [JsonPropertyName("elements")]
        public List<RichTextSection> Elements { get; set; } = new List<RichTextSection>();
        [JsonPropertyName("style")]
        public string Style { get; set; }    
        [JsonPropertyName("indent")]
        public int Indent { get; set; }
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
        [JsonPropertyName("border")]
        public int Border { get; set; }
    }
}