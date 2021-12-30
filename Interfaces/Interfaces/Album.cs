namespace Interfaces
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Album : Audio, IPlayable, IListenable, ICollection<Song>, IComparable<Album>
    {
        readonly ICollection<Song> _songs;

        public Album(string title) : base(title)
        {
            _songs = new List<Song>();
        }

        public Album(string title, ICollection<Song> songs) : base(title)
        {
            _songs = songs;
        }

        public string Play()
        {
            return $"The {GetTitle()} album is being played. Songs: {string.Join(", ", _songs)}";
        }

        public string Listen()
        {
            return $"The {GetTitle()} album is being listened to.";
        }

        /// <summary>
        /// Polymorphic implementation of Content GetTitle() that trims whitespace.
        /// </summary>
        /// <returns>String: The Album Title with whitespace trimmed.</returns>
        public override string GetTitle()
        {
            return base.GetTitle().Trim();
        }

        public void Add(Song item)
        {
            _songs.Add(item);
        }

        public void Clear()
        {
            _songs?.Clear();
        }

        public bool Contains(Song item)
        {
            return _songs.Contains(item);
        }

        public void CopyTo(Song[] array, int arrayIndex)
        {
            _songs.CopyTo(array, arrayIndex);
        }

        public bool Remove(Song item)
        {
            return (bool)(_songs?.Remove(item));
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return _songs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _songs.GetEnumerator();
        }

        public int CompareTo(Album other)
        {
            return CompareTo(other);
        }

        public int Count => _songs.Count;

        public bool IsReadOnly => false;
    }
}