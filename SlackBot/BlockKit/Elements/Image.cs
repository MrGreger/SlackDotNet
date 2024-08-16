using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class Image : ElementBase, ISectionElement, IContextElement
    {
        public override string Type => ElementTypes.Image;
        [JsonPropertyName("alt_text")]
        public string Alt { get; set; }
        [JsonPropertyName("image_url")]
        public string Url { get; set; }
        [JsonPropertyName("slack_file")]
        public SlackFile SlackFile { get; set; }
    }
}