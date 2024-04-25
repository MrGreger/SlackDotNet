using HttpSlackBot.Blocks.Dialog;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IConfirmationDialog
    {
        IConfirmationDialog WithTitle(string title, bool emoji = true);
        IConfirmationDialog WithText(string text, bool emoji = true);
        IConfirmationDialog WithConfirm(string confirmText, bool emoji = true);
        IConfirmationDialog WithDeny(string denyText, bool emoji = true);
        IConfirmationDialog WithStyle(string style);
    }
    
    public class ConfirmationDialogBuilder : IConfirmationDialog
    {
        private ConfirmationDialog _confirmationDialog = new ConfirmationDialog();

        public IConfirmationDialog WithTitle(string title, bool emoji = true)
        {
            _confirmationDialog.Title = new PlainText(emoji)
            {
                Value = title
            };
            return this;
        }

        public IConfirmationDialog WithText(string text, bool emoji = true)
        {
            _confirmationDialog.Text = new PlainText(emoji)
            {
                Value = text
            };
            return this;
        }

        public IConfirmationDialog WithConfirm(string confirmText, bool emoji = true)
        {
            _confirmationDialog.Confirm = new PlainText(emoji)
            {
                Value = confirmText
            };
            return this;
        }

        public IConfirmationDialog WithDeny(string denyText, bool emoji = true)
        {
            _confirmationDialog.Deny = new PlainText(emoji)
            {
                Value = denyText
            };
            return this;
        }

        public IConfirmationDialog WithStyle(string style)
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