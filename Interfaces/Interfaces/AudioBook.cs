namespace Interfaces
{
    internal class AudioBook : Audio, IPlayable, IListenable
    {
        public AudioBook(string title): base(title)
        {
        }

        public string Listen()
        {
            return ($"AudioBook {base.GetTitle()} is being listened to.");
        }

        public string Play()
        {
            return($"AudioBook {base.GetTitle()} is being played.");
        }        
    }
}