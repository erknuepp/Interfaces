namespace Interfaces
{
    internal abstract class Content
    {
        private readonly string _title;

        public Content(string title)
        {
            _title = title;
        }

        public virtual string GetTitle() { return _title; }

        public override string ToString()
        {
            return _title;
        }
    }
}