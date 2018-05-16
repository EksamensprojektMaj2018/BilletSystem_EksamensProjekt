using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BilletSystem_EksamensProjekt.Annotations;

namespace BilletSystem_EksamensProjekt
{
    public class movie : INotifyPropertyChanged
    {
        private List<movie_showtime> _movies;
        private movie_showtime _selectedMovie;

        public movie()
        {
            _movies = new List<movie_showtime>();
            _movies.Add(new movie_showtime("Avengers: Infinity War", 1, "Dette er bare en superhelte film", "20/4-18"));
            _movies.Add(new movie_showtime("Deadpool 2", 2, "Dette er bare en anti-superhelte film", "15/5-18"));
            _movies.Add(new movie_showtime("Film 3", 3, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "15/5-18"));
            _selectedMovie = _movies[0];
        }

        public List<movie_showtime> Movies
        {
            get { return _movies; }
        }

        public movie_showtime SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}