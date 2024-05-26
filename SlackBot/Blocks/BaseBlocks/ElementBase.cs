using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.BaseBlocks
{
    public abstract class ElementBase
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}