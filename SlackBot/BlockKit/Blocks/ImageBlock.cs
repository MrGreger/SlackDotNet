using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class ImageBlock : BlockBase
    {
        public override string Type => BlockTypes.Image;
        [JsonPropertyName("alt_text")]
        public string AltText { get; set; }
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("slack_file")]
        public SlackFile SlackFile { get; set; }
        [JsonPropertyName("text")]
        public PlainText Title { get; set; }
    }
}