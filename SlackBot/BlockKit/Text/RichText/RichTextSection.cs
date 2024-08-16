using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class RichTextSection : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.TextSection;
        [JsonPropertyName("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
    }
}