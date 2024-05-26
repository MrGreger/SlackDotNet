using HttpSlackBot.Blocks.Checkbox;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IRadioButtonOptionConfigurator
    {
        IRadioButtonOptionConfigurator WithText(string text, TextType textType = TextType.Plain, bool emoji = true);

        IRadioButtonOptionConfigurator WithDescription(string text, TextType textType = TextType.Plain,
            bool emoji = true);

        IRadioButtonOptionConfigurator WithValue(string text);
        IRadioButtonOptionConfigurator Initial(bool initial = true);
    }

    public class RadioButtonOptionBuilder : IRadioButtonOptionConfigurator
    {
        private InputOption _option = new InputOption();
        private bool _initial;
        
        public IRadioButtonOptionConfigurator WithText(string text, TextType textType = TextType.Plain,
            bool emoji = true)
        {
            _option.Text = new TextAttribute(textType.ConvertToString(), emoji)
            {
                Value = text
            };

            return this;
        }

        public IRadioButtonOptionConfigurator WithDescription(string text, TextType textType = TextType.Plain,
            bool emoji = true)
        {
            _option.Description = new TextAttribute(textType.ConvertToString(), emoji)
            {
                Value = text
            };

            return this;
        }

        public IRadioButtonOptionConfigurator WithValue(string text)
        {
            _option.Value = text;
            return this;
        }

        public IRadioButtonOptionConfigurator Initial(bool initial = true)
        {
            _initial = initial;
            return this;
        }

        public (InputOption option, bool initial) Build()
        {
            return (_option, _initial);
        }
    }
}