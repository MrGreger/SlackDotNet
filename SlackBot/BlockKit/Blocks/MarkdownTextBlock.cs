using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class MarkdownTextBlock : Section
    {
        public MarkdownTextBlock(bool withEmoji)
        {
            Text = new TextAttribute(TextType.Markdown.ConvertToString(), withEmoji);
        }

        public override string Type => BlockTypes.Section;
    }
}
