using SlackBotDotNet.BlockKit.Text.RichText.Elements;

namespace SlackBotDotNet.BlockKit.Builders.Elements.RichText.Elements
{
    public interface ITextConfigurator
    {
        ITextConfigurator WithText(string text);
        ITextConfigurator Bold(bool bold = true);
        ITextConfigurator Italic(bool italic = true);
        ITextConfigurator Strike(bool strike = true);
        ITextConfigurator Code(bool code = true);
    }

    public class TextBuilder : ITextConfigurator
    {
        private TextElement _text = new TextElement()
        {
            Style = new TextElementStyle()
        };

        public ITextConfigurator WithText(string text)
        {
            _text.Text = text;

            return this;
        }

        public ITextConfigurator Bold(bool bold = true)
        {
            _text.Style.Bold = bold;

            return this;
        }

        public ITextConfigurator Italic(bool italic = true)
        {
            _text.Style.Italic = italic;

            return this;
        }

        public ITextConfigurator Strike(bool strike = true)
        {
            _text.Style.Strike = strike;

            return this;
        }

        public ITextConfigurator Code(bool code = true)
        {
            _text.Style.Code = code;

            return this;
        }

        public TextElement Build()
        {
            return _text;
        }
    }
}