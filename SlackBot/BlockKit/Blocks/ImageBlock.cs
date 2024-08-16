using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class ImageBlock : BlockBase
    {
        public override string Type => BlockTypes.Image;
        [JsonProperty("alt_text")]
        public string AltText { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("slack_file")]
        public SlackFile SlackFile { get; set; }
        [JsonProperty("text")]
        public PlainText Title { get; set; }
    }
}