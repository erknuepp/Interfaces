namespace Interfaces
{
    using System;
    using System.Collections.Generic;

    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        ContentLibrary contentLibrary;

        public MainPage()
        {
            InitializeComponent();

            contentLibrary = new ContentLibrary();

            contentTypePicker.ItemsSource = new List<string>
            {
                "Book",
                "AudioBook",
                "Movie",
                "Album",
                "Song"
            };
        }

        public void AddContentButtonClicked(object sender, EventArgs e)
        {
            var contentType = contentTypePicker.SelectedItem as string;
            var title = contentTitle.Text;

            switch (contentType)
            {
                case "Book":
                    contentLibrary.Contents.Add(new Book(title));
                    break;
                case "AudioBook":
                    contentLibrary.Contents.Add(new AudioBook(title));
                    break;
                case "Movie":
                    contentLibrary.Contents.Add(new Movie(title));
                    contentLibrary.Contents.Add(new Movie(title + " w/ Subtitles", new Subtitle(new Dictionary<string, string> { { "SceneOne", "In a world" } })));
                    break;
                case "Album":
                    contentLibrary.Contents.Add(new Album(title));
                    break;
                case "Song":
                    contentLibrary.Contents.Add(new Song(title));
                    break;
                default:
                    break;
            }
            contentTypePicker.SelectedIndex = -1;
            contentTitle.Text = "";
            contentLibraryListView.ItemsSource = contentLibrary.Contents;
        }

        public void PlayButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is Movie movie)
                {
                    stateMessage.Text = movie.Play();
                }
                else if (selectedContentItem is Song song)
                {
                    stateMessage.Text = song.Play();
                }
                else if (selectedContentItem is AudioBook audioBook)
                {
                    stateMessage.Text = audioBook.Play();
                }
                else if (selectedContentItem is Album album)
                {
                    stateMessage.Text = album.Play();
                }
                else
                {
                    stateMessage.Text = $"This action is not supported for {selectedContentItem.GetType().Name} Content Type.";
                }
            }
        }

        public void ReadButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is Book book)
                {
                    stateMessage.Text = book.Read();
                }
                else if (selectedContentItem is Movie movie)
                {
                    stateMessage.Text = movie.Read();
                }
            }
        }

        public void ViewButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is Movie movie)
                {
                    stateMessage.Text = movie.View();
                }
            }
        }

        public void ListenButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is AudioBook audioBook)
                {
                    stateMessage.Text = audioBook.Listen();
                }
                if (selectedContentItem is Song song)
                {
                    stateMessage.Text = song.Listen();
                }
                if (selectedContentItem is Album album)
                {
                    stateMessage.Text = album.Listen();
                }
            }
        }

        public void DisposeButtonClicked(object sender, EventArgs e)
        {
            contentLibrary.Dispose();
            contentLibraryListView.ItemsSource = null;
            contentLibraryListView.ItemsSource = contentLibrary.Contents;
        }
    }
}
