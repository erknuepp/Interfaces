namespace Interfaces
{
    internal class Video : Content
    {
        public Video(string title) : base(title)
        {
        }

        public string Title()
        {
            return base.GetTitle();
        }
    }
}