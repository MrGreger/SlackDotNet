using System;

namespace HttpSlackBot.Blocks.Builders.RichText.Elements
{
    public interface ILinkConfigurator
    {
        ILinkConfigurator WithUrl(string url);
        ILinkConfigurator WithText(string text);
        ILinkConfigurator Unsafe(bool @unsafe = true);
        ILinkConfigurator Bold(bool bold = true);
        ILinkConfigurator Italic(bool italic = true);
        ILinkConfigurator Strike(bool strike = true);
        ILinkConfigurator Code(bool code = true);
    }
    
    public class LinkBuilder : ILinkConfigurator
    {
        private LinkElement _link = new LinkElement()
        {
            Style = new LinkElementStyle()
        };
        
        public ILinkConfigurator WithUrl(string url)
        {
            _link.Url = url;

            return this;
        }

        public ILinkConfigurator WithText(string text)
        {
            _link.Text = text;

            return this;
        }

        public ILinkConfigurator Unsafe(bool @unsafe = true)
        {
            _link.Unsafe = @unsafe;

            return this;
        }

        public ILinkConfigurator Bold(bool bold = true)
        {
            _link.Style.Bold = bold;

            return this;
        }

        public ILinkConfigurator Italic(bool italic = true)
        {
            _link.Style.Italic = italic;

            return this;
        }

        public ILinkConfigurator Strike(bool strike = true)
        {
            _link.Style.Strike = strike;

            return this;
        }

        public ILinkConfigurator Code(bool code = true)
        {
            _link.Style.Code = code;

            return this;
        }

        public LinkElement Build()
        {
            if (string.IsNullOrWhiteSpace(_link.Url))
            {
                throw new Exception("Url is empty");
            }

            return _link;
        }
    }
}