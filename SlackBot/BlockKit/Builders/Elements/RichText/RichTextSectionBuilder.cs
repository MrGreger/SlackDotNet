using SlackBotDotNet.BlockKit.Text.RichText;
using SlackBotDotNet.BlockKit.Text.RichText.Elements;

namespace SlackBotDotNet.BlockKit.Builders.Elements.RichText
{
    public interface IRichTextSectionConfigurator : IElementsContainerConfigurator
    {
         
    }
    
    public class RichTextSectionBuilder : ElementsContainer, IRichTextSectionConfigurator
    {
        private RichTextSection _textSection = new RichTextSection();
        
        protected override void AddElement(RichTextElementBase element)
        {
            _textSection.Elements.Add(element);
        }

        public RichTextSection Build()
        {
            return _textSection;
        }
    }
}