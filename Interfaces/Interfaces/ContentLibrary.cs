namespace Interfaces
{
    using System;
    using System.Collections.ObjectModel;

    internal sealed class ContentLibrary : IDisposable
    {
        private ObservableCollection<Content> _contents;

        public ContentLibrary()
        {
            _contents = new ObservableCollection<Content>();
        }

        public void Add(Content content)
        {
            _contents.Add(content);
        }

        public void Dispose()
        {
            _contents = new ObservableCollection<Content> { null };
        }

        public ObservableCollection<Content> Contents => _contents; 
    }
}