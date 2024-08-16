using System;
using System.Collections.Generic;
using System.Linq;
using SlackBotDotNet.BlockKit.Elements;

namespace SlackBotDotNet.BlockKit.Builders.Elements
{
    public interface IAllowedFilesConfigurator
    {
        IAllowedFilesConfigurator Allow(string fileExtension);
    }

    public class AllowedFilesBuilder : IAllowedFilesConfigurator
    {
        private HashSet<string> _files = new HashSet<string>();


        public IAllowedFilesConfigurator Allow(string fileExtension)
        {
            _files.Add(fileExtension);
            return this;
        }

        public string[] Build()
        {
            return _files.ToArray();
        }
    }
    
    public interface IFileInputConfigurator
    {
        IFileInputConfigurator WithActionId(string actionId);
        IFileInputConfigurator WithAllowedFiles(Action<IAllowedFilesConfigurator> builder);
        IFileInputConfigurator WithMaxFiles(int max);
    }

    public class FileInputBuilder : IFileInputConfigurator
    {
        private FileInput _fileInput = new FileInput();
        
        public IFileInputConfigurator WithActionId(string actionId)
        {
            _fileInput.ActionId = actionId;
            return this;
        }

        public IFileInputConfigurator WithAllowedFiles(Action<IAllowedFilesConfigurator> builder)
        {
            var extensionsBuilder = new AllowedFilesBuilder();
            
            builder.Invoke(extensionsBuilder);

            _fileInput.FileTypes = extensionsBuilder.Build();
            
            return this;
        }

        public IFileInputConfigurator WithMaxFiles(int max)
        {
            if (max < 1 || max > 10)
            {
                throw new ArgumentException("value should be between 1 and 10");
            }
            return this;
        }

        public FileInput Build()
        {
            return _fileInput;
        }
    }
}