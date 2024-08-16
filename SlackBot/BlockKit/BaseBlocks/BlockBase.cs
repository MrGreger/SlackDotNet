using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.BaseBlocks
{
    public abstract class BlockBase
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
        [JsonProperty("block_id")]
        public string BlockId { get; set; }
    }
}
