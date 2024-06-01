using System;
using HttpSlackBot.Blocks.Builders.Text;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IContextSectionConfigurator : ITextContainer<IContextSectionConfigurator>,
                                                   IImageContainer<IContextSectionConfigurator>
    {
        IContextSectionConfigurator WithId(string id);
    }

    public class ContextSectionBuilder : IContextSectionConfigurator
    {
        private ContextSection _section = new ContextSection();
        
        public IContextSectionConfigurator WithText(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);
            
            _section.Elements.Add(builder.Build<TextAttribute>());
            
            return this;
        }

        public IContextSectionConfigurator WithImage(Action<IImageConfigurator> configurator)
        {
            var builder = new ImageBuilder();

            configurator.Invoke(builder);
            
            _section.Elements.Add(builder.Build());
            
            return this;
        }

        public IContextSectionConfigurator WithId(string id)
        {
            _section.BlockId = id;
            return this;
        }

        public ContextSection Build()
        {
            return _section;
        }
    }
}