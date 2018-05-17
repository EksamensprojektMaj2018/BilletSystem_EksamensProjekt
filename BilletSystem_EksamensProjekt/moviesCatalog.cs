using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BilletSystem_EksamensProjekt
{
    public class moviesCatalog
    {
        private List<movies> _movies;
        private movies _selectedMovie;

        public movies()
        {
            _movies = new List<movies>();
            _movies.Add(new movies("Avengers: Infinity War", "Dette er bare en superhelte film", "20/4-18"));
            _movies.Add(new movies("Deadpool 2", "Dette er bare en anti-superhelte film", "15/5-18"));
            _movies.Add(new movies("Film 3", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "15/5-18"));
            _selectedMovie = _movies[0];
        }

        public List<movies> Movies
        {
            get { return _movies; }
        }

        public movies SelectedMovie
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