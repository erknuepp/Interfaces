namespace Interfaces
{
    using System;

    internal sealed class Song : Audio, IPlayable, IListenable
    {
        private TimeSpan playTime;
        public Song(string title):base(title)
        {
            playTime = new TimeSpan();
        }

        public Song(string title, TimeSpan playTime) : base(title)
        {
            this.playTime = playTime;
        }

        public string Play()
        {
            return($"The song {base.GetTitle()} is being played.");
        }

        public string Listen()
        {
            return($"The song {base.GetTitle()} is being listened to.");
        }

        public override string ToString()
        {
            return GetTitle();
        }

        public TimeSpan PlayTime => playTime;
    }
}