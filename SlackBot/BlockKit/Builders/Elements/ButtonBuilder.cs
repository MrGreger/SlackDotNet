using System;
using SlackBot.Blocks.Dialog;

namespace SlackBot.Blocks.Builders
{
    public interface IButtonConfigurator
    {
        IButtonConfigurator WithText(string text);
        IButtonConfigurator WithPayload(string payload);
        IButtonConfigurator WithActionId(string actionId);
        IButtonConfigurator WithUrl(string url);
        IButtonConfigurator WithStyle(string style);
        IButtonConfigurator WithAccessibilityLabel(string label);
        IButtonConfigurator WithEmoji(bool withEmoji = true);
        IButtonConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> dialogBuilder);
    }

    public class ButtonBuilder : IButtonConfigurator
    {
        private string _text = null;
        private string _value = null;
        private string _actionId = null;
        private string _url = null;
        private string _style = null;
        private ConfirmationDialog _confirmationDialog = null;
        private string _accessibilityLabel = null;
        private bool _emoji = false;

        public IButtonConfigurator WithText(string text)
        {
            _text = text;
            return this;
        }

        public IButtonConfigurator WithPayload(string payload)
        {
            _value = payload;
            return this;
        }

        public IButtonConfigurator WithActionId(string actionId)
        {
            _actionId = actionId;
            return this;
        }

        public IButtonConfigurator WithUrl(string url)
        {
            _url = url;
            return this;
        }

        public IButtonConfigurator WithStyle(string style)
        {
            _style = style;
            return this;
        }

        public IButtonConfigurator WithAccessibilityLabel(string label)
        {
            _accessibilityLabel = label;
            return this;
        }

        public IButtonConfigurator WithEmoji(bool withEmoji = true)
        {
            _emoji = withEmoji;
            return this;
        }

        public IButtonConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> dialogBuilder)
        {
            var builder = new ConfirmationDialogConfiguratorBuilder();

            builder.WithTitle("Missing title")
                .WithText("Missing text")
                .WithConfirm("Ok")
                .WithDeny("Cancel");

            dialogBuilder.Invoke(builder);

            _confirmationDialog = builder.Build();

            return this;
        }

        public Button Build()
        {
            if (_text == null)
            {
                throw new Exception("Button text is null! Use WithText to assign text.");
            }

            if (_text.Length > 75)
            {
                throw new Exception("Button text max length is more than 75.");
            }

            return new Button()
            {
                ActionId = _actionId,
                Value = _value,
                Style = _style,
                AccessibilityLabel = _accessibilityLabel,
                Content = new PlainText(_emoji)
                {
                    Value = _text
                },
                Url = _url
            };
        }
    }
}