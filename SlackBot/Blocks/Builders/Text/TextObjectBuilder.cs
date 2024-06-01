using System;

namespace HttpSlackBot.Blocks.Builders.Text
{
    public interface ITextConfiguratorBase<T>
    {
        T Emoji(bool emoji = true);
        T WithText(string text);
    }

    public interface IPlainTextConfigurator : ITextConfiguratorBase<IPlainTextConfigurator>
    {
    }

    public interface IMarkdownConfigurator : ITextConfiguratorBase<IMarkdownConfigurator>
    {
        IMarkdownConfigurator Verbatim(bool verbatim = true);
    }

    public interface ITextObjectConfigurator
    {
        IPlainTextConfigurator Plain(string initialText = null);
        IMarkdownConfigurator Markdown(string initialText = null);
    }

    public interface ITextAttributeBuilder
    {
        TextAttribute Build();
    }

    public class PlainTextBuilder : IPlainTextConfigurator, ITextAttributeBuilder
    {
        private TextAttribute _text;

        public PlainTextBuilder(string initialText)
        {
            _text = new PlainText(true)
            {
                Value = initialText
            };
        }

        public IPlainTextConfigurator Emoji(bool emoji = true)
        {
            _text.Emoji = emoji;
            return this;
        }

        public IPlainTextConfigurator WithText(string text)
        {
            _text.Value = text;

            return this;
        }

        public TextAttribute Build()
        {
            return _text;
        }
    }

    public class MarkdownTextBuilder : IMarkdownConfigurator, ITextAttributeBuilder
    {
        private TextAttribute _text;

        public MarkdownTextBuilder(string initialText)
        {
            _text = new TextAttribute(TextType.Markdown.ConvertToString(), true)
            {
                Value = initialText
            };
        }

        public IMarkdownConfigurator Emoji(bool emoji = true)
        {
            _text.Emoji = emoji;
            return this;
        }

        public IMarkdownConfigurator WithText(string text)
        {
            _text.Value = text;

            return this;
        }

        public IMarkdownConfigurator Verbatim(bool verbatim = true)
        {
            _text.Verbatim = verbatim;
            return this;
        }

        public TextAttribute Build()
        {
            return _text;
        }
    }


    public class TextObjectObjectBuilder : ITextObjectConfigurator
    {
        private ITextAttributeBuilder _builder;

        public IPlainTextConfigurator Plain(string initialText = null)
        {
            _builder = new PlainTextBuilder(initialText);
            return _builder as IPlainTextConfigurator;
        }

        public IMarkdownConfigurator Markdown(string initialText = null)
        {
            _builder = new MarkdownTextBuilder(initialText);
            return _builder as IMarkdownConfigurator;
        }

        public T Build<T>() where T : TextAttribute
        {
            return (T)_builder.Build();
        }
    }
}