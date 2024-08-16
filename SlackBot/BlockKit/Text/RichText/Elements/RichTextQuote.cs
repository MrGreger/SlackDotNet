using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class RichTextQuote : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.QuoteSection;
        [JsonPropertyName("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
        [JsonPropertyName("border")]
        public int Border { get; set; }
    }
}