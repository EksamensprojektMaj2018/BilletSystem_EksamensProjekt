using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BilletSystem_EksamensProjekt.Annotations;

namespace BilletSystem_EksamensProjekt
{
    public class movie : INotifyPropertyChanged
    {
        private List<forestillinger> _movies;
        private forestillinger _selectedMovie;

        public movie()
        {
            _movies = new List<forestillinger>();
            _movies.Add(new forestillinger("Avengers: Infinity War", 1, "", "Dette er bare en superhelte film", "20/4-18"));
            _movies.Add(new forestillinger("Deadpool 2", 2, "", "Dette er bare en anti-superhelte film", "15/5-18"));
            _movies.Add(new forestillinger("Film 3", 3, "", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "15/5-18"));
            _selectedMovie = _movies[0];
        }

        public List<forestillinger> Movies
        {
            get { return _movies; }
        }

        public forestillinger SelectedMovie
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