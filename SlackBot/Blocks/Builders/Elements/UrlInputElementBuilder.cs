using System;
using HttpSlackBot.Blocks.Builders.Actions;
using HttpSlackBot.Blocks.Elements;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IUrlInputElementConfigurator
    {
        IUrlInputElementConfigurator WithActionId(string action);
        IUrlInputElementConfigurator WithInitialValue(string initialValue);
        IUrlInputElementConfigurator WithDispatchActions(Action<IDispatchActionConfigurator> configurator);
        IUrlInputElementConfigurator FocusOnLoad(bool focus);
        IUrlInputElementConfigurator WithPlaceholder(string text, bool emoji = true);
    }
    
    public class UrlInputElementBuilder : IUrlInputElementConfigurator
    {
        private UrlInputElement _urlInput = new UrlInputElement();
        
        public IUrlInputElementConfigurator WithActionId(string action)
        {
            _urlInput.ActionId = action;

            return this;
        }

        public IUrlInputElementConfigurator WithInitialValue(string initialValue)
        {
            _urlInput.InitialValue = initialValue;

            return this;
        }

        public IUrlInputElementConfigurator WithDispatchActions(Action<IDispatchActionConfigurator> configurator)
        {
            var builder = new DispatchActionConfigurationBuilder();
            
            configurator.Invoke(builder);

            _urlInput.DispatchActions = builder.Build();

            return this;
        }

        public IUrlInputElementConfigurator FocusOnLoad(bool focus)
        {
            _urlInput.FocusOnLoad = focus;

            return this;
        }

        public IUrlInputElementConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _urlInput.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public UrlInputElement Build()
        {
            return _urlInput;
        }
    }
}