using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;

namespace SlackBotDotNet.BlockKit.Elements
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