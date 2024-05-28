using System;
using HttpSlackBot.Blocks.Builders.Actions;

namespace HttpSlackBot.Blocks.Builders
{
    public interface ITextInputConfigurator
    {
        ITextInputConfigurator WithActionId(string actionId);
        ITextInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder);
        ITextInputConfigurator FocusOnLoad(bool focus);
        ITextInputConfigurator Multiline(bool multiline = true);
        ITextInputConfigurator WithMaxLength(int maxLength);
        ITextInputConfigurator WithMinLength(int minLength);
        ITextInputConfigurator WithInitialValue(string initial);
        ITextInputConfigurator WithPlaceholder(string placeholder, bool emoji = true);
    }
    
    public class TextInputBuilder : ITextInputConfigurator
    {
        private PlainTextInput _plainTextInput = new PlainTextInput();
        
        public ITextInputConfigurator WithActionId(string actionId)
        {
            _plainTextInput.ActionId = actionId;
            return this;
        }

        public ITextInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder)
        {
            var actionsBuilder = new DispatchActionConfigurationBuilder();
            
            builder.Invoke(actionsBuilder);

            _plainTextInput.DispatchActions = actionsBuilder.Build();
            
            return this;
        }

        public ITextInputConfigurator FocusOnLoad(bool focus)
        {
            _plainTextInput.FocusOnLoad = focus;
            return this;
        }

        public ITextInputConfigurator Multiline(bool multiline = true)
        {
            _plainTextInput.Multiline = multiline;
            return this;
        }

        public ITextInputConfigurator WithMaxLength(int maxLength)
        {
            _plainTextInput.MaxLength = maxLength;
            return this;
        }

        public ITextInputConfigurator WithMinLength(int minLength)
        {
            _plainTextInput.MaxLength = minLength;
            return this;
        }

        public ITextInputConfigurator WithInitialValue(string initial)
        {
            _plainTextInput.InitialValue = initial;
            return this;
        }

        public ITextInputConfigurator WithPlaceholder(string placeholder, bool emoji = true)
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