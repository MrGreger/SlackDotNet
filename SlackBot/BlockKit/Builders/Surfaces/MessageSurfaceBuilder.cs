using System;
using SlackBotDotNet.BlockKit.Builders.Blocks;
using SlackBotDotNet.BlockKit.Surfaces;

namespace SlackBotDotNet.BlockKit.Builders.Surfaces
{
    public interface IMessageSurfaceBuilder
    {
        IMessageSurfaceBuilder AddSection(Action<ISectionConfigurator> builder);
        IMessageSurfaceBuilder AddActionsBlock(Action<IActionsBlockConfigurator> builder);
        IMessageSurfaceBuilder AddContextBlock(Action<IContextBlockConfigurator> builder);
        IMessageSurfaceBuilder AddDivider(Action<IDividerConfigurator> builder);
        IMessageSurfaceBuilder AddHeaderBlock(Action<IHeaderBlockConfigurator> builder);
        IMessageSurfaceBuilder AddImageBlock(Action<IImageBlockConfigurator> builder);
        IMessageSurfaceBuilder AddInputBlock(Action<IInputBlockConfigurator> builder);
        IMessageSurfaceBuilder AddRichTextBlock(Action<IRichTextBlockConfigurator> builder);
        IMessageSurfaceBuilder AddVideoBlock(Action<IVideoBlockConfigurator> builder);
    }

    public class MessageSurfaceBuilder : IMessageSurfaceBuilder
    {
        private MessageSurface _container = new MessageSurface();

        public IMessageSurfaceBuilder AddSection(Action<ISectionConfigurator> builder)
        {
            var blockBuilder = new SectionBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddActionsBlock(Action<IActionsBlockConfigurator> builder)
        {
            var blockBuilder = new ActionsBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddContextBlock(Action<IContextBlockConfigurator> builder)
        {
            var blockBuilder = new ContextBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddDivider(Action<IDividerConfigurator> builder)
        {
            var blockBuilder = new DividerBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddHeaderBlock(Action<IHeaderBlockConfigurator> builder)
        {
            var blockBuilder = new HeaderBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddImageBlock(Action<IImageBlockConfigurator> builder)
        {
            var blockBuilder = new ImageBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddInputBlock(Action<IInputBlockConfigurator> builder)
        {
            var blockBuilder = new InputBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddRichTextBlock(Action<IRichTextBlockConfigurator> builder)
        {
            var blockBuilder = new RichTextBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public IMessageSurfaceBuilder AddVideoBlock(Action<IVideoBlockConfigurator> builder)
        {
            var blockBuilder = new VideoBlockBuilder();

            builder.Invoke(blockBuilder);

            _container.Add(blockBuilder.Build());

            return this;
        }

        public string Build()
        {
            return _container.Serialize();
        }
    }
}