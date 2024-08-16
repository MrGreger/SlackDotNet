using Newtonsoft.Json;

namespace SlackBot.Blocks.BaseBlocks
{
    public abstract class ElementBase
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}