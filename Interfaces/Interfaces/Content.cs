namespace Interfaces
{
    using System;

    internal abstract class Content : IComparable
    {
        private readonly string _title;

        public Content(string title)
        {
            _title = title;
        }

        public int CompareTo(object obj)
        {
            var content = obj as Content;
            if (content == null) return 1;
            
            return _title.CompareTo(content._title);
        }

        public virtual string GetTitle() { return _title; }

        public override string ToString()
        {
            return _title;
        }
    }
}