using System;
using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;

namespace HttpSlackBot.Blocks.Builders
{
    public class BlockedMessageBuilder
    {
        private BlocksContainer _container = new BlocksContainer();

        public BlockedMessageBuilder AddSection(Action<SectionBuilder> builder)
        {
            var sectionBuilder = new SectionBuilder();

            builder.Invoke(sectionBuilder);

            _container.Add(sectionBuilder.Build());
            
            return this;
        }
    }
}