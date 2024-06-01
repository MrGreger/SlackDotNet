using System;
using HttpSlackBot.Blocks.Builders.Actions;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IPlainTextInputConfigurator
    {
        IPlainTextInputConfigurator WithActionId(string actionId);
        IPlainTextInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder);
        IPlainTextInputConfigurator FocusOnLoad(bool focus);
        IPlainTextInputConfigurator Multiline(bool multiline = true);
        IPlainTextInputConfigurator WithMaxLength(int maxLength);
        IPlainTextInputConfigurator WithMinLength(int minLength);
        IPlainTextInputConfigurator WithInitialValue(string initial);
        IPlainTextInputConfigurator WithPlaceholder(string placeholder, bool emoji = true);
    }
    
    public class PlainTextInputBuilder : IPlainTextInputConfigurator
    {
        private PlainTextInput _plainTextInput = new PlainTextInput();
        
        public IPlainTextInputConfigurator WithActionId(string actionId)
        {
            _plainTextInput.ActionId = actionId;
            return this;
        }

        public IPlainTextInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder)
        {
            var actionsBuilder = new DispatchActionConfigurationBuilder();
            
            builder.Invoke(actionsBuilder);

            _plainTextInput.DispatchActions = actionsBuilder.Build();
            
            return this;
        }

        public IPlainTextInputConfigurator FocusOnLoad(bool focus)
        {
            _plainTextInput.FocusOnLoad = focus;
            return this;
        }

        public IPlainTextInputConfigurator Multiline(bool multiline = true)
        {
            _plainTextInput.Multiline = multiline;
            return this;
        }

        public IPlainTextInputConfigurator WithMaxLength(int maxLength)
        {
            _plainTextInput.MaxLength = maxLength;
            return this;
        }

        public IPlainTextInputConfigurator WithMinLength(int minLength)
        {
            _plainTextInput.MaxLength = minLength;
            return this;
        }

        public IPlainTextInputConfigurator WithInitialValue(string initial)
        {
            _plainTextInput.InitialValue = initial;
            return this;
        }

        public IPlainTextInputConfigurator WithPlaceholder(string placeholder, bool emoji = true)
        {
            _plainTextInput.Placeholder = new PlainText(emoji)
            {
                Value = placeholder
            };
            return this;
        }

        public PlainTextInput Build()
        {
            return _plainTextInput;
        }
    }
}