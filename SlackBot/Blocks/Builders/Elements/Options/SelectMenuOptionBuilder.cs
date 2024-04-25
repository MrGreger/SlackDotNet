namespace HttpSlackBot.Blocks.Builders
{
    public interface ISelectMenuOptionConfigurator
    {
        ISelectMenuOptionConfigurator WithText(string text, bool emoji = true);
        ISelectMenuOptionConfigurator WithDescription(string text, bool emoji = true);
        ISelectMenuOptionConfigurator WithValue(string text);
    }
    
    public class SelectMenuOptionBuilder
    {
        
    }
}