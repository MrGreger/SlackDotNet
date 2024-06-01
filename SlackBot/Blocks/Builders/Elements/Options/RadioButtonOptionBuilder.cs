using System;
using HttpSlackBot.Blocks.Builders.Text;
using HttpSlackBot.Blocks.Checkbox;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IRadioButtonOptionConfigurator
    {
        IRadioButtonOptionConfigurator WithText(Action<ITextObjectConfigurator> configurator);

        IRadioButtonOptionConfigurator WithDescription(Action<ITextObjectConfigurator> configurator);

        IRadioButtonOptionConfigurator WithValue(string text);
        IRadioButtonOptionConfigurator Initial(bool initial = true);
    }

    public class RadioButtonOptionBuilder : IRadioButtonOptionConfigurator
    {
        private InputOption _option = new InputOption();
        private bool _initial;

        public IRadioButtonOptionConfigurator WithText(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);

            _option.Text = builder.Build<TextAttribute>();

            return this;
        }

        public IRadioButtonOptionConfigurator WithDescription(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);

            _option.Description = builder.Build<TextAttribute>();

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