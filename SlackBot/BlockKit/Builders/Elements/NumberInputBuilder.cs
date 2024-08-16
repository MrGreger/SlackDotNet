using System;
using HttpSlackBot.Blocks.Builders.Actions;

namespace HttpSlackBot.Blocks.Builders
{
    public interface INumberInputConfigurator
    {
        INumberInputConfigurator WithActionId(string actionId);
        INumberInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder);
        INumberInputConfigurator FocusOnLoad(bool focus);
        INumberInputConfigurator AllowDecimal(bool allow = true);
        INumberInputConfigurator WithMaxValue(string maxValue);
        INumberInputConfigurator WithMinValue(string minValue);
        INumberInputConfigurator WithInitialValue(string initial);
        INumberInputConfigurator WithPlaceholder(string placeholder, bool emoji = true);
    }
    
    public class NumberInputBuilder : INumberInputConfigurator
    {
        private NumberInput _numberInput = new NumberInput();
        
        public INumberInputConfigurator WithActionId(string actionId)
        {
            return this;
        }

        public INumberInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder)
        {
            var actionsBuilder = new DispatchActionConfigurationBuilder();

            builder.Invoke(actionsBuilder);

            _numberInput.DispatchActions = actionsBuilder.Build();
            
            return this;
        }

        public INumberInputConfigurator FocusOnLoad(bool focus)
        {
            _numberInput.FocusOnLoad = focus;
            return this;
        }

        public INumberInputConfigurator AllowDecimal(bool allow = true)
        {
            _numberInput.AllowDecimal = allow;
            return this;
        }

        public INumberInputConfigurator WithMaxValue(string maxValue)
        {
            _numberInput.MaxValue = maxValue;
            return this;
        }

        public INumberInputConfigurator WithMinValue(string minValue)
        {
            _numberInput.MinValue = minValue;
            return this;
        }

        public INumberInputConfigurator WithInitialValue(string initial)
        {
            _numberInput.InitialValue = initial;
            return this;
        }

        public INumberInputConfigurator WithPlaceholder(string placeholder, bool emoji = true)
        {
            _numberInput.Placeholder = new PlainText(emoji)
            {
                Value = placeholder
            };
            return this;
        }

        public NumberInput Build()
        {
            return _numberInput;
        }
    }
}