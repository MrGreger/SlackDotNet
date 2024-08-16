using System;
using SlackBot.Blocks.Builders.RichText.Elements;

namespace SlackBot.Blocks.Builders.RichText
{
    public interface IRichTextListConfigurator
    {
        IRichTextListConfigurator AsBullet();
        IRichTextListConfigurator AsOrdered();
        IRichTextListConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator);
        IRichTextListConfigurator WithIndent(int indent);
        IRichTextListConfigurator WithOffset(int offset);
        IRichTextListConfigurator WithBorder(int border);
    }
    
    public class RichTextListBuilder : IRichTextListConfigurator
    {
        private RichTextListSection _richTextList = new RichTextListSection();
        
        public IRichTextListConfigurator AsBullet()
        {
            _richTextList.Style = RichTextListSectionStyle.Bullet;
            return this;
        }

        public IRichTextListConfigurator AsOrdered()
        {
            _richTextList.Style = RichTextListSectionStyle.Ordered;
            return this;
        }

        public IRichTextListConfigurator WithTextSection(Action<IRichTextSectionConfigurator> configurator)
        {
            var builder = new RichTextSectionBuilder();
            
            configurator.Invoke(builder);
            
            _richTextList.Elements.Add(builder.Build());
            
            return this;
        }

        public IRichTextListConfigurator WithIndent(int indent)
        {
            _richTextList.Indent = indent;
            
            return this;
        }

        public IRichTextListConfigurator WithOffset(int offset)
        {
            _richTextList.Offset = offset;
            
            return this;
        }

        public IRichTextListConfigurator WithBorder(int border)
        {
            _richTextList.Border = border;
            
            return this;
        }

        public RichTextListSection Build()
        {
            return _richTextList;
        }
    }
}