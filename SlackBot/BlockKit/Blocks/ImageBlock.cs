using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Blocks
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