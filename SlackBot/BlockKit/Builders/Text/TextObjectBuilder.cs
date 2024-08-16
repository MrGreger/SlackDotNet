using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Text
{
    public interface ITextConfiguratorBase<T>
    {
        T WithEmoji(bool emoji = true);
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


    public interface ITextAttributeBuilder<out T> where T : TextAttribute
    {
        T Build();
    }

    public class PlainTextBuilder : IPlainTextConfigurator, ITextAttributeBuilder<PlainText>
    {
        private PlainText _text;

        public PlainTextBuilder(string initialText)
        {
            _text = new PlainText(true)
                    {
                        Value = initialText
                    };
        }

        public IPlainTextConfigurator WithEmoji(bool emoji = true)
        {
            _text.Emoji = emoji;
            return this;
        }

        public IPlainTextConfigurator WithText(string text)
        {
            _text.Value = text;

            return this;
        }

        public PlainText Build()
        {
            return _text;
        }
    }

    public class MarkdownTextBuilder : IMarkdownConfigurator, ITextAttributeBuilder<MarkdownText>
    {
        private MarkdownText _text;

        public MarkdownTextBuilder(string initialText)
        {
            _text = new MarkdownText(true)
                    {
                        Value = initialText
                    };
        }

        public IMarkdownConfigurator WithEmoji(bool emoji = true)
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

        public MarkdownText Build()
        {
            return _text;
        }
    }


    public class TextObjectObjectBuilder : ITextObjectConfigurator
    {
        private ITextAttributeBuilder<TextAttribute> _builder;

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

        public TextAttribute Build()
        {
            return _builder.Build();
        }
    }
}