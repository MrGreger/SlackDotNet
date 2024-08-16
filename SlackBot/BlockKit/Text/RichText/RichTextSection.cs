using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Text.RichText.Elements;

namespace SlackBotDotNet.BlockKit.Text.RichText
{
    public class RichTextSection : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.TextSection;
        [JsonProperty("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
    }
}