using SlackBotDotNet.BlockKit.Options;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements.Options
{
    public interface ISelectMenuOptionConfigurator
    {
        ISelectMenuOptionConfigurator WithText(string text, bool emoji = true);
        ISelectMenuOptionConfigurator WithDescription(string text, bool emoji = true);
        ISelectMenuOptionConfigurator WithValue(string text);
        ISelectMenuOptionConfigurator Initial(bool initial = true);
    }

    public class SelectMenuOptionBuilder : ISelectMenuOptionConfigurator
    {
        private bool _initial = false;
        private InputOption _option = new InputOption();

        public ISelectMenuOptionConfigurator WithText(string text, bool emoji = true)
        {
            _option.Text = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public ISelectMenuOptionConfigurator WithDescription(string text, bool emoji = true)
        {
            _option.Description = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public ISelectMenuOptionConfigurator WithValue(string text)
        {
            _option.Value = text;

            return this;
        }

        public ISelectMenuOptionConfigurator Initial(bool initial = true)
        {
            _initial = initial;

            return this;
        }

        public (InputOption Option, bool Initial) Build()
        {
            return (_option, _initial);
        }
    }
}