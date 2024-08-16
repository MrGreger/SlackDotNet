using System;

namespace HttpSlackBot.Blocks.Builders.RichText.Elements
{
    public interface IChannelConfigurator
    {
        IChannelConfigurator WithId(string channelId);
        IChannelConfigurator Bold(bool bold = true);
        IChannelConfigurator Italic(bool italic = true);
        IChannelConfigurator Strike(bool strike = true);        
        IChannelConfigurator Highlight(bool highlight = true);
        IChannelConfigurator ClientHighlight(bool clientHighlight = true);
        IChannelConfigurator Unlink(bool unlink = true);
    }
    
    public class ChannelBuilder : IChannelConfigurator
    {
        private ChannelElement _channel = new ChannelElement()
        {
            Style = new ChannelElementStyle()
        };
        
        public IChannelConfigurator WithId(string channelId)
        {
            _channel.Channel = channelId;

            return this;
        }

        public IChannelConfigurator Bold(bool bold = true)
        {
            _channel.Style.Bold = bold;

            return this;
        }

        public IChannelConfigurator Italic(bool italic = true)
        {
            _channel.Style.Italic = italic;

            return this;
        }

        public IChannelConfigurator Strike(bool strike = true)
        {
            _channel.Style.Strike = strike;

            return this;
        }

        public IChannelConfigurator Highlight(bool highlight = true)
        {
            _channel.Style.Highlight = highlight;

            return this;
        }

        public IChannelConfigurator ClientHighlight(bool clientHighlight = true)
        {
            _channel.Style.ClientHighlight = clientHighlight;

            return this;
        }

        public IChannelConfigurator Unlink(bool unlink = true)
        {
            _channel.Style.Unlink = unlink;

            return this;
        }

        public ChannelElement Build()
        {
            if (string.IsNullOrWhiteSpace(_channel.Channel))
            {
                throw new Exception("Channel is null");
            }
            
            return _channel;
        }
    }
}