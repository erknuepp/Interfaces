namespace Interfaces
{
    using System.Collections.Generic;

    internal sealed class Subtitle
    {
        private Dictionary<string, string> subtitles;

        public Subtitle() : this(new Dictionary<string, string>())
        {
        }

        public Subtitle(Dictionary<string, string> subtitles)
        {
            this.subtitles = subtitles;
        }
    }
}