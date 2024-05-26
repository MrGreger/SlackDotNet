using System;
using HttpSlackBot.Blocks.Builders.Elements.RichText;
using HttpSlackBot.Blocks.Builders.RichText.Elements;

namespace HttpSlackBot.Blocks.Builders.RichText
{
    public interface IRichTextConfigurator
    {
        IRichTextConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator);
        IRichTextConfigurator WithTextListSection(Action<IRichTextListConfigurator> configurator);
        IRichTextConfigurator WithTextPreformatted(Action<IRichTextPreformattedConfigurator> configurator);
        IRichTextConfigurator WithTextQuote(Action<IRichTextQuoteConfigurator> configurator);
        IRichTextConfigurator WithBlockId(string id);
    }
    
    public class RichTextBuilder : IRichTextConfigurator
    {
        private Blocks.RichText _richText = new Blocks.RichText();
        
        public IRichTextConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator)
        {
            var builder = new RichTextSectionBuilder();

            configurator.Invoke(builder);
            
            _richText.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextConfigurator WithTextListSection(Action<IRichTextListConfigurator> configurator)
        {
            var builder = new RichTextListBuilder();

            configurator.Invoke(builder);
            
            _richText.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextConfigurator WithTextPreformatted(Action<IRichTextPreformattedConfigurator> configurator)
        {
            var builder = new RichTextPreformattedBuilder();

            configurator.Invoke(builder);
            
            _richText.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextConfigurator WithTextQuote(Action<IRichTextQuoteConfigurator> configurator)
        {
            var builder = new RichTextQuoteBuilder();

            configurator.Invoke(builder);
            
            _richText.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextConfigurator WithBlockId(string id)
        {
            _richText.BlockId = id;

            return this;
        }

        public Blocks.RichText Build()
        {
            return _richText;
        }
    }
}