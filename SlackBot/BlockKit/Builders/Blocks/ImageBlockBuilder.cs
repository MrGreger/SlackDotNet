using System;
using HttpSlackBot.Blocks.Builders.Text;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IImageBlockConfigurator
    {
        IImageBlockConfigurator WithId(string id);
        IImageBlockConfigurator WithAltText(string text);
        IImageBlockConfigurator WithUrl(string url);
        IImageBlockConfigurator WithSlackFile(SlackFile file);
        IImageBlockConfigurator WithTitle(Action<IPlainTextConfigurator> textConfigurator);
    }

    public class ImageBlockBuilder : IImageBlockConfigurator
    {
        private string _url;
        private SlackFile _slackFile;
        private PlainText _title;
        private string _altText;
        private string _id;

        public IImageBlockConfigurator WithId(string id)
        {
            _id = id;
            return this;
        }

        public IImageBlockConfigurator WithAltText(string text)
        {
            _altText = text;
            return this;
        }

        public IImageBlockConfigurator WithUrl(string url)
        {
            if (_slackFile != null)
            {
                throw new InvalidOperationException("Slack file is already defined");
            }

            _url = url;
            return this;
        }

        public IImageBlockConfigurator WithSlackFile(SlackFile file)
        {
            if (_url != null)
            {
                throw new InvalidOperationException("Url is already defined");
            }

            _slackFile = file;
            return this;
        }

        public IImageBlockConfigurator WithTitle(Action<IPlainTextConfigurator> textConfigurator)
        {
            var builder = new PlainTextBuilder("Image");

            textConfigurator.Invoke(builder);

            _title = builder.Build();
            return this;
        }

        public ImageBlock Build()
        {
            if (_url == null && _slackFile == null)
            {
                throw new InvalidOperationException("Image is required");
            }

            return new ImageBlock()
                   {
                       AltText = _altText ?? throw new InvalidOperationException("Alt text is required"),
                       ImageUrl = _url,
                       SlackFile = _slackFile,
                       BlockId = _id,
                       Title = _title
                   };
        }
    }
}