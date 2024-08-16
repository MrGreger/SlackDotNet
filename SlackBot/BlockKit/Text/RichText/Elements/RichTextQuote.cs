using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Text.RichText.Elements
{
    public class RichTextQuote : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.QuoteSection;
        [JsonProperty("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
        [JsonProperty("border")]
        public int Border { get; set; }
    }
}