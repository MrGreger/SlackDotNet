using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Text.RichText.Elements;

namespace SlackBotDotNet.BlockKit.Text.RichText
{
    public class RichTextPreformatted : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.PreformatedSection;
        [JsonProperty("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
        [JsonProperty("border")]
        public int Border { get; set; }
    }
}