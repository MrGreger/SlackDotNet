using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class PlainTextBlock : Section
    {
        public PlainTextBlock(bool withEmoji)
        {
            Text = new TextAttribute(TextType.Plain.ConvertToString(), withEmoji);
        }

        public PlainTextBlock(string text, bool withEmoji = false) : this(withEmoji)
        {
            Text.Value = text;
        }
    }
}
