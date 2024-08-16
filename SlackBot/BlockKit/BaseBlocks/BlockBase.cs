using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks.BaseBlocks
{
    public abstract class BlockBase
    {
        [JsonPropertyName("type")]
        public abstract string Type { get; }
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; }
    }
}
