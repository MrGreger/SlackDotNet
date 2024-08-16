using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class FileBlock : BlockBase
    {
        public override string Type => BlockTypes.File;
        
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }
        [JsonPropertyName("source")]
        public string Source { get; set; } = "remote";
    }
}