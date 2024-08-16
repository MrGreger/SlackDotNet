using System;
using HttpSlackBot.Blocks.Builders.Actions;
using HttpSlackBot.Blocks.Builders.RichText;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IRichTextInputConfigurator
    {
        IRichTextInputConfigurator WithActionId(string action);
        IRichTextInputConfigurator WithInitialValue(Action<IRichTextBlockConfigurator> configurator);
        IRichTextInputConfigurator WithDispatchActions(Action<IDispatchActionConfigurator> configurator);
        IRichTextInputConfigurator FocusOnLoad(bool focus);
        IRichTextInputConfigurator WithPlaceholder(string text, bool emoji = true);
    }

    public class RichTextInputBuilder : IRichTextInputConfigurator
    {
        private RichTextInput _richTextInput = new RichTextInput();

        public IRichTextInputConfigurator WithActionId(string action)
        {
            _richTextInput.ActionId = action;

            return this;
        }

        public IRichTextInputConfigurator WithInitialValue(Action<IRichTextBlockConfigurator> configurator)
        {
            var builder = new RichTextBlockBuilder();

            configurator.Invoke(builder);

            _richTextInput.InitialValue = builder.Build();

            return this;
        }

        public IRichTextInputConfigurator WithDispatchActions(Action<IDispatchActionConfigurator> configurator)
        {
            var builder = new DispatchActionConfigurationBuilder();

            configurator.Invoke(builder);

            _richTextInput.DispatchActions = builder.Build();

            return this;
        }

        public IRichTextInputConfigurator FocusOnLoad(bool focus)
        {
            _richTextInput.FocusOnLoad = focus;

            return this;
        }

        public IRichTextInputConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _richTextInput.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public RichTextInput Build()
        {
            return _richTextInput;
        }
    }
}