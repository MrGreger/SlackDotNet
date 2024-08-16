using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class Image : ElementBase, ISectionElement, IContextElement
    {
        public override string Type => ElementTypes.Image;
        [JsonProperty("alt_text")]
        public string Alt { get; set; }
        [JsonProperty("image_url")]
        public string Url { get; set; }
        [JsonProperty("slack_file")]
        public SlackFile SlackFile { get; set; }
    }
}