using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
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