namespace HttpSlackBot.Blocks.Builders
{
    public interface IImageConfigurator
    {
        IImageConfigurator WithAlt(string altText);
        IImageConfigurator WithFile(SlackFile file);
        IImageConfigurator WithUrl(string url);
    }
    
    public class ImageBuilder:IImageConfigurator
    {
        private Image _image = new Image();
        
        public IImageConfigurator WithAlt(string altText)
        {
            _image.Alt = altText;

            return this;
        }

        public IImageConfigurator WithFile(SlackFile file)
        {
            _image.Url = null;
            _image.SlackFile = file;

            return this;
        }

        public IImageConfigurator WithUrl(string url)
        {
            _image.SlackFile = null;
            _image.Url = url;

            return this;
        }

        public Image Build()
        {
            return _image;
        }
    }
}