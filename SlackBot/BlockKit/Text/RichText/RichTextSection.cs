using System.Collections.Generic;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class RichTextSection : RichTextSectionBase
    {
        public override string Type => RichTextSectionTypes.TextSection;
        [JsonProperty("elements")]
        public List<RichTextElementBase> Elements { get; set; } = new List<RichTextElementBase>();
    }
}