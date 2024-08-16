using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class MessageSurface
    {
        public IReadOnlyCollection<BlockBase> Blocks => _blocks.AsReadOnly();

        private List<BlockBase> _blocks;

        public MessageSurface()
        {
            _blocks = new List<BlockBase>();
        }

        public MessageSurface Add(BlockBase element)
        {
            _blocks.Add(element);
            return this;
        }

        public MessageSurface AddRange(IEnumerable<BlockBase> blocks)
        {
            _blocks.AddRange(blocks);
            return this;
        }

        public MessageSurface Remove(BlockBase element)
        {
            _blocks.Remove(element);
            return this;
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(_blocks, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
