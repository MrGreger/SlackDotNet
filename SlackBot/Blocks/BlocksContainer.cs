﻿using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks
{
    public class BlocksContainer
    {
        public IReadOnlyCollection<BlockBase> Blocks => _blocks.AsReadOnly();

        private List<BlockBase> _blocks;

        public BlocksContainer()
        {
            _blocks = new List<BlockBase>();
        }

        public BlocksContainer Add(BlockBase element)
        {
            _blocks.Add(element);
            return this;
        }

        public BlocksContainer AddRange(IEnumerable<BlockBase> blocks)
        {
            _blocks.AddRange(blocks);
            return this;
        }

        public BlocksContainer Remove(BlockBase element)
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
