using System;
using SlackBotDotNet.BlockKit.Blocks;
using SlackBotDotNet.BlockKit.Builders.Text;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Blocks
{
    /// <summary>
    /// https://api.slack.com/reference/block-kit/blocks#video
    /// </summary>
    public interface IVideoBlockConfigurator
    {
        IVideoBlockConfigurator WithId(string id);

        /// <summary>
        /// Required
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithAltText(string text);

        IVideoBlockConfigurator WithAuthorName(string authorName);

        /// <summary>
        /// Preferred
        /// </summary>
        /// <param name="textConfigurator"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithDescription(Action<IPlainTextConfigurator> textConfigurator);

        IVideoBlockConfigurator WithVideoProviderIconUrl(string url);
        IVideoBlockConfigurator WithProviderName(string name);

        /// <summary>
        /// Required
        /// </summary>
        /// <param name="textConfigurator"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithTitle(Action<IPlainTextConfigurator> textConfigurator);

        /// <summary>
        /// Preferred
        /// </summary>
        /// <param name="titleUrl"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithTitleUrl(string titleUrl);

        /// <summary>
        /// Required
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithThumbnailImageUrl(string url);

        /// <summary>
        /// Required
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IVideoBlockConfigurator WithVideoUrl(string url);
    }

    public class VideoBlockBuilder : IVideoBlockConfigurator
    {
        private string _id;
        private string _altText;
        private string _authorName;
        private PlainText _description;
        private string _providerIcon;
        private string _providerName;
        private PlainText _tile;
        private string _titleUrl;
        private string _thumbnailUrl;
        private string _videoUrl;

        public IVideoBlockConfigurator WithId(string id)
        {
            _id = id;
            return this;
        }

        public IVideoBlockConfigurator WithAltText(string text)
        {
            _altText = text;
            return this;
        }

        public IVideoBlockConfigurator WithAuthorName(string authorName)
        {
            _authorName = authorName;
            return this;
        }

        public IVideoBlockConfigurator WithDescription(Action<IPlainTextConfigurator> textConfigurator)
        {
            var builder = new PlainTextBuilder("Description");

            textConfigurator.Invoke(builder);
            _description = builder.Build();
            return this;
        }

        public IVideoBlockConfigurator WithVideoProviderIconUrl(string url)
        {
            _providerIcon = url;
            return this;
        }

        public IVideoBlockConfigurator WithProviderName(string name)
        {
            _providerName = name;
            return this;
        }

        public IVideoBlockConfigurator WithTitle(Action<IPlainTextConfigurator> textConfigurator)
        {
            var builder = new PlainTextBuilder("Title");

            textConfigurator.Invoke(builder);
            _tile = builder.Build();
            return this;
        }

        public IVideoBlockConfigurator WithTitleUrl(string titleUrl)
        {
            _titleUrl = titleUrl;
            return this;
        }

        public IVideoBlockConfigurator WithThumbnailImageUrl(string url)
        {
            _thumbnailUrl = url;
            return this;
        }

        public IVideoBlockConfigurator WithVideoUrl(string url)
        {
            _videoUrl = url;
            return this;
        }

        public VideoBlock Build()
        {
            if (_altText == null)
            {
                throw new InvalidOperationException("Alt text is required");
            }

            if (_tile == null)
            {
                throw new InvalidOperationException("Title is required");
            }

            if (_altText == null)
            {
                throw new InvalidOperationException("Thumbnail url is required");
            }

            if (_altText == null)
            {
                throw new InvalidOperationException("Video url is required");
            }

            return new VideoBlock()
                   {
                       Description = _description,
                       Title = _tile,
                       AltText = _altText,
                       AuthorName = _authorName,
                       BlockId = _id,
                       ProviderName = _providerName,
                       ThumbnailUrl = _thumbnailUrl,
                       TitleUrl = _titleUrl,
                       VideoUrl = _videoUrl,
                       ProviderIconUrl = _providerIcon
                   };
        }
    }
}