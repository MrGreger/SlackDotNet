using SlackBot.Blocks.Builders.RichText;

namespace SlackBot.Blocks.Builders.Elements.RichText
{
    public interface IRichTextQuoteConfigurator : IElementsContainerConfigurator
    {
        IRichTextQuoteConfigurator WithBorder(int thickness);
    }

    public class RichTextQuoteBuilder : ElementsContainer, IRichTextQuoteConfigurator
    {
        protected RichTextQuote _quote = new RichTextQuote();

        protected override void AddElement(RichTextElementBase element)
        {
            _quote.Elements.Add(element);
        }

        public IRichTextQuoteConfigurator WithBorder(int thickness)
        {
            _quote.Border = thickness;

            return this;
        }

        public RichTextQuote Build()
        {
            return _quote;
        }
    }
}