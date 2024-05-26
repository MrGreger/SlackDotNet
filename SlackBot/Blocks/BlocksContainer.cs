using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks
{
    public class BlocksContainer
    {
        public IReadOnlyCollection<ElementBase> Blocks => _blocks.AsReadOnly();

        private List<ElementBase> _blocks;

        public BlocksContainer()
        {
            _blocks = new List<ElementBase>();
        }

        public BlocksContainer Add(ElementBase element)
        {
            _blocks.Add(element);
            return this;
        }

        public BlocksContainer AddRange(IEnumerable<ElementBase> blocks)
        {
            _blocks.AddRange(blocks);
            return this;
        }

        public BlocksContainer Remove(ElementBase element)
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
