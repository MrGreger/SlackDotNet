using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks.BaseBlocks
{
    public abstract class BlockBase
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
        [JsonProperty("block_id")]
        public string BlockId { get; set; }
    }
}
