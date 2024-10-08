using System;
using SlackBotDotNet.BlockKit.Builders.Actions;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements
{
    public interface IEmailInputConfigurator
    {
        IEmailInputConfigurator WithActionId(string actionId);
        IEmailInputConfigurator WithInitialValue(string value);
        IEmailInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder);
        IEmailInputConfigurator FocusOnLoad(bool focus);
        IEmailInputConfigurator WithPlaceholder(string placeholder, bool emoji = true);
    }
    
    public class EmailInputBuilder : IEmailInputConfigurator
    {
        private EmailInput _emailInput = new EmailInput();


        public IEmailInputConfigurator WithActionId(string actionId)
        {
            _emailInput.ActionId = actionId;
            return this;
        }

        public IEmailInputConfigurator WithInitialValue(string value)
        {
            _emailInput.InitialValue = value;
            return this;
        }

        public IEmailInputConfigurator DispatchOn(Action<IDispatchActionConfigurator> builder)
        {
            var actionsBuilder = new DispatchActionConfigurationBuilder();
            
            builder.Invoke(actionsBuilder);

            _emailInput.DispatchActions = actionsBuilder.Build();
            
            return this;
        }

        public IEmailInputConfigurator FocusOnLoad(bool focus)
        {
            _emailInput.FocusOnLoad = focus;
            return this;
        }

        public IEmailInputConfigurator WithPlaceholder(string placeholder, bool emoji = true)
        {
            _emailInput.Placeholder = new PlainText(emoji)
            {
                Value = placeholder
            };
            return this;
        }

        public EmailInput Build()
        {
            return _emailInput;
        }
    }
}