using System.Text.Json.Serialization;

namespace SlackBot.Blocks.BaseBlocks
{
    public abstract class ElementBase
    {
        [JsonPropertyName("type")]
        public abstract string Type { get; }
    }
}