using System;
using SlackBotDotNet.BlockKit.Blocks;
using SlackBotDotNet.BlockKit.Builders.Elements;
using SlackBotDotNet.BlockKit.Builders.Text;

namespace SlackBotDotNet.BlockKit.Builders.Blocks
{
    public interface IContextBlockConfigurator : ITextContainer<IContextBlockConfigurator>,
                                                 IImageContainer<IContextBlockConfigurator>
    {
        IContextBlockConfigurator WithId(string id);
    }

    public class ContextBlockBuilder : IContextBlockConfigurator
    {
        private ContextBlock _block = new ContextBlock();

        public IContextBlockConfigurator WithText(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);

            _block.Elements.Add(builder.Build());

            return this;
        }

        public IContextBlockConfigurator WithImage(Action<IImageConfigurator> configurator)
        {
            var builder = new ImageBuilder();

            configurator.Invoke(builder);

            _block.Elements.Add(builder.Build());

            return this;
        }

        public IContextBlockConfigurator WithId(string id)
        {
            _block.BlockId = id;
            return this;
        }

        public ContextBlock Build()
        {
            return _block;
        }
    }
}