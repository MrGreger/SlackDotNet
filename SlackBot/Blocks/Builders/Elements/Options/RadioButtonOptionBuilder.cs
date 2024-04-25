namespace HttpSlackBot.Blocks.Builders
{
    
    public interface IRadioButtonOptionConfigurator
    {
        IRadioButtonOptionConfigurator WithText(string text, TextType textType = TextType.Plain, bool emoji = true);
        IRadioButtonOptionConfigurator WithDescription(string text, TextType textType = TextType.Plain, bool emoji = true);
        IRadioButtonOptionConfigurator WithValue(string text);
    }
    
    public class RadioButtonOptionBuilder
    {
        
    }
}