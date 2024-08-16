using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class FileBlock : BlockBase
    {
        public override string Type => BlockTypes.File;
        
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; } = "remote";
    }
}