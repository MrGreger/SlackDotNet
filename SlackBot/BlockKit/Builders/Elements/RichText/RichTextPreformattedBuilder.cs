using SlackBot.Blocks.Builders.RichText;

namespace SlackBot.Blocks.Builders.Elements.RichText
{
    public interface IRichTextPreformattedConfigurator : IElementsContainerConfigurator
    {
        IRichTextPreformattedConfigurator WithBorder(int thickness);
    }

    public class RichTextPreformattedBuilder : ElementsContainer, IRichTextPreformattedConfigurator
    {
        protected RichTextPreformatted _preformatted = new RichTextPreformatted();
        
        protected override void AddElement(RichTextElementBase element)
        {
            _preformatted.Elements.Add(element);
        }

        public IRichTextPreformattedConfigurator WithBorder(int thickness)
        {
            _preformatted.Border = thickness;
            
            return this;
        }

        public RichTextPreformatted Build()
        {
            return _preformatted;
        }
    }
}