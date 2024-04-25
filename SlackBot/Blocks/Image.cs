using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class Image : BlockBase
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