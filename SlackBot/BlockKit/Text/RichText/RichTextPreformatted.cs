using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class RichTextPreformatted : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.PreformatedSection;
        [JsonPropertyName("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
        [JsonPropertyName("border")]
        public int Border { get; set; }
    }
}