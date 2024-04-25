namespace HttpSlackBot.Blocks
{
    public class PlainText : TextAttribute
    {
        public PlainText(bool emoji) : base(TextType.Plain.ConvertToString(), emoji)
        {
        }
    }
}