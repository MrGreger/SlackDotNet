using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.BaseBlocks
{
    public abstract class ElementBase
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}