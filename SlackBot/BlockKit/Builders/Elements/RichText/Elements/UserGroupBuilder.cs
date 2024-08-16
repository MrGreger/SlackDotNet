using System;

namespace HttpSlackBot.Blocks.Builders.RichText.Elements
{
    public interface IUserGroupConfigurator
    {
        IUserGroupConfigurator WithId(string id);
        IUserGroupConfigurator Bold(bool bold = true);
        IUserGroupConfigurator Italic(bool italic = true);
        IUserGroupConfigurator Strike(bool strike = true);        
        IUserGroupConfigurator Highlight(bool highlight = true);
        IUserGroupConfigurator ClientHighlight(bool clientHighlight = true);
        IUserGroupConfigurator Unlink(bool unlink = true);
    }

    public class UserGroupBuilder : IUserGroupConfigurator
    {
        private UserGroupElement _userGroupElement = new UserGroupElement()
        {
            Style = new UserGroupElementStyle()
        };
        
        public IUserGroupConfigurator WithId(string id)
        {
            _userGroupElement.GroupId = id;

            return this;
        }

        public IUserGroupConfigurator Bold(bool bold = true)
        {
            _userGroupElement.Style.Bold = bold;

            return this;
        }

        public IUserGroupConfigurator Italic(bool italic = true)
        {
            _userGroupElement.Style.Italic = italic;

            return this;
        }

        public IUserGroupConfigurator Strike(bool strike = true)
        {
            _userGroupElement.Style.Strike = strike;

            return this;
        }

        public IUserGroupConfigurator Highlight(bool highlight = true)
        {
            _userGroupElement.Style.Highlight = highlight;

            return this;
        }

        public IUserGroupConfigurator ClientHighlight(bool clientHighlight = true)
        {
            _userGroupElement.Style.ClientHighlight = clientHighlight;

            return this;
        }

        public IUserGroupConfigurator Unlink(bool unlink = true)
        {
            _userGroupElement.Style.Unlink = unlink;

            return this;
        }

        public UserGroupElement Build()
        {
            if (string.IsNullOrWhiteSpace(_userGroupElement.GroupId))
            {
                throw new Exception("Id is empty");
            }

            return _userGroupElement;
        }
    }
}