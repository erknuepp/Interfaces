namespace Interfaces
{
    internal class Book : Text, IReadable
    {
        private int _numnerOfPages;

        public Book(string title) : base(title)
        {
        }

        public string Read()
        {
            return $"The book {base.GetTitle()} is being read";
        }
    }
}