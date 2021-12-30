namespace Interfaces
{
    using System;

    internal sealed class Movie : Video, IPlayable, IViewable, IListenable, IReadable
    {
        private readonly Subtitle _subtitle;
        private TimeSpan _duration;

        public Movie(string title) : base(title)
        {
        }

        public Movie(string title, Subtitle subtitle) : base(title)
        {
            _subtitle = subtitle;
        }

        public string Listen()
        {
            return $"The movie {GetTitle()} is being listened to.";
        }

        public string Play()
        {
            return $"The movie {GetTitle()} is being played.";
        }

        public string View()
        {
            return $"The movie {GetTitle()} is being viewed.";
        }

        public bool HasSubtitles => _subtitle != null;


        public string Read()
        {
            if (HasSubtitles)
            {
                return $"The movie {GetTitle()} has subtitles on.";
            }
            else
            {
                return $"The movie {GetTitle()} does not have subtitles.";
            }
        }
    }
}