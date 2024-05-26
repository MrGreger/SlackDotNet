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
        private TextInput _textInput = new TextInput();
        
        public ITextInputConfigurator WithActionId(string actionId)
        {
            _textInput.ActionId = actionId;
            return this;
        }

        public ITextInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder)
        {
            var actionsBuilder = new DispatchActionConfigurationBuilder();
            
            builder.Invoke(actionsBuilder);

            _textInput.DispatchActions = actionsBuilder.Build();
            
            return this;
        }

        public ITextInputConfigurator FocusOnLoad(bool focus)
        {
            _textInput.FocusOnLoad = focus;
            return this;
        }

        public ITextInputConfigurator Multiline(bool multiline = true)
        {
            _textInput.Multiline = multiline;
            return this;
        }

        public ITextInputConfigurator WithMaxLength(int maxLength)
        {
            _textInput.MaxLength = maxLength;
            return this;
        }

        public ITextInputConfigurator WithMinLength(int minLength)
        {
            _textInput.MaxLength = minLength;
            return this;
        }

        public ITextInputConfigurator WithInitialValue(string initial)
        {
            _textInput.InitialValue = initial;
            return this;
        }

        public ITextInputConfigurator WithPlaceholder(string placeholder, bool emoji = true)
        {
            _textInput.Placeholder = new PlainText(emoji)
            {
                Value = placeholder
            };
            return this;
        }

        public TextInput Build()
        {
            return _textInput;
        }
    }
}