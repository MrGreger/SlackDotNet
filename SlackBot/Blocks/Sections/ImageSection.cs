using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class ImageSection : BlockBase
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