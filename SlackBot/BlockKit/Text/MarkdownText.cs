namespace SlackBotDotNet.BlockKit.Text
{
    public class MarkdownText: TextAttribute
    {
        public MarkdownText(bool emoji) : base(TextType.Markdown.ConvertToString(), emoji)
        {
        }
    }
}