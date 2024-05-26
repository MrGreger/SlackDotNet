using System;

namespace HttpSlackBot.Blocks.Builders.RichText.Elements
{
    public interface IUserConfigurator
    {
        IUserConfigurator WithId(string id);
        IUserConfigurator Bold(bool bold = true);
        IUserConfigurator Italic(bool italic = true);
        IUserConfigurator Strike(bool strike = true);        
        IUserConfigurator Highlight(bool highlight = true);
        IUserConfigurator ClientHighlight(bool clientHighlight = true);
        IUserConfigurator Unlink(bool unlink = true);
    }

    public class UserBuilder : IUserConfigurator
    {
        private UserElement _userElement = new UserElement()
        {
            Style = new UserElementStyle()
        };
        
        public IUserConfigurator WithId(string id)
        {
            _userElement.UserId = id;

            return this;
        }

        public IUserConfigurator Bold(bool bold = true)
        {
            _userElement.Style.Bold = bold;

            return this;
        }

        public IUserConfigurator Italic(bool italic = true)
        {
            _userElement.Style.Italic = italic;

            return this;
        }

        public IUserConfigurator Strike(bool strike = true)
        {
            _userElement.Style.Strike = strike;

            return this;
        }

        public IUserConfigurator Highlight(bool highlight = true)
        {
            _userElement.Style.Highlight = highlight;

            return this;
        }

        public IUserConfigurator ClientHighlight(bool clientHighlight = true)
        {
            _userElement.Style.ClientHighlight = clientHighlight;

            return this;
        }

        public IUserConfigurator Unlink(bool unlink = true)
        {
            _userElement.Style.Unlink = unlink;

            return this;
        }

        public UserElement Build()
        {
            if (string.IsNullOrWhiteSpace(_userElement.UserId))
            {
                throw new Exception("Id is empty");
            }

            return _userElement;
        }
    }
}