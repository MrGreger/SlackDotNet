using HttpSlackBot.Blocks.Dialog;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IConfirmationDialogConfigurator
    {
        IConfirmationDialogConfigurator WithTitle(string title, bool emoji = true);
        IConfirmationDialogConfigurator WithText(string text, bool emoji = true);
        IConfirmationDialogConfigurator WithConfirm(string confirmText, bool emoji = true);
        IConfirmationDialogConfigurator WithDeny(string denyText, bool emoji = true);
        IConfirmationDialogConfigurator WithStyle(string style);
    }
    
    public class ConfirmationDialogConfiguratorBuilder : IConfirmationDialogConfigurator
    {
        private ConfirmationDialog _confirmationDialog = new ConfirmationDialog();

        public IConfirmationDialogConfigurator WithTitle(string title, bool emoji = true)
        {
            _confirmationDialog.Title = new PlainText(emoji)
            {
                Value = title
            };
            return this;
        }

        public IConfirmationDialogConfigurator WithText(string text, bool emoji = true)
        {
            _confirmationDialog.Text = new PlainText(emoji)
            {
                Value = text
            };
            return this;
        }

        public IConfirmationDialogConfigurator WithConfirm(string confirmText, bool emoji = true)
        {
            _confirmationDialog.Confirm = new PlainText(emoji)
            {
                Value = confirmText
            };
            return this;
        }

        public IConfirmationDialogConfigurator WithDeny(string denyText, bool emoji = true)
        {
            _confirmationDialog.Deny = new PlainText(emoji)
            {
                Value = denyText
            };
            return this;
        }

        public IConfirmationDialogConfigurator WithStyle(string style)
        {
            _confirmationDialog.Style = style;
            return this;
        }

        public ConfirmationDialog Build()
        {
            return _confirmationDialog;
        }
    }
}