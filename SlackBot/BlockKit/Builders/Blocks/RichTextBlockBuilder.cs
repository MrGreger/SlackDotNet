using System;
using SlackBot.Blocks.Builders.Elements.RichText;
using SlackBot.Blocks.Builders.RichText.Elements;

namespace SlackBot.Blocks.Builders.RichText
{
    public interface IRichTextBlockConfigurator
    {
        IRichTextBlockConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator);
        IRichTextBlockConfigurator WithTextListSection(Action<IRichTextListConfigurator> configurator);
        IRichTextBlockConfigurator WithTextPreformatted(Action<IRichTextPreformattedConfigurator> configurator);
        IRichTextBlockConfigurator WithTextQuote(Action<IRichTextQuoteConfigurator> configurator);
        IRichTextBlockConfigurator WithBlockId(string id);
    }
    
    public class RichTextBlockBuilder : IRichTextBlockConfigurator
    {
        private RichTextBlock _richTextBlock = new RichTextBlock();
        
        public IRichTextBlockConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator)
        {
            var builder = new RichTextSectionBuilder();

            configurator.Invoke(builder);
            
            _richTextBlock.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextBlockConfigurator WithTextListSection(Action<IRichTextListConfigurator> configurator)
        {
            var builder = new RichTextListBuilder();

            configurator.Invoke(builder);
            
            _richTextBlock.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextBlockConfigurator WithTextPreformatted(Action<IRichTextPreformattedConfigurator> configurator)
        {
            var builder = new RichTextPreformattedBuilder();

            configurator.Invoke(builder);
            
            _richTextBlock.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextBlockConfigurator WithTextQuote(Action<IRichTextQuoteConfigurator> configurator)
        {
            var builder = new RichTextQuoteBuilder();

            configurator.Invoke(builder);
            
            _richTextBlock.Elements.Add(builder.Build());

            return this;
        }

        public IRichTextBlockConfigurator WithBlockId(string id)
        {
            _richTextBlock.BlockId = id;

            return this;
        }

        public Blocks.RichTextBlock Build()
        {
            return _richTextBlock;
        }
    }
}