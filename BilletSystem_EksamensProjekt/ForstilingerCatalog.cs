using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BilletSystem_EksamensProjekt
{
    public class ForestillingerCatalog : INotifyPropertyChanged
    {
        #region Instance Field

        private moviesCatalog _movies;
        private salCatalog _sale;
        private TidspunktCatalog _tidspunkt;
        private Forestillinger _selectedForestillinger;

        private List<Forestillinger> _forestillinger;

        #endregion

        #region Constructor

        public ForestillingerCatalog()
        {
            _forestillinger = new List<Forestillinger>();
            _movies = new moviesCatalog();
            _sale = new salCatalog();
            _tidspunkt = new TidspunktCatalog();

            _forestillinger.Add(new Forestillinger(_movies.Movies[0], _sale.sal[0], _tidspunkt.Tid[0]));
            _forestillinger.Add(new Forestillinger(_movies.Movies[1], _sale.sal[0], _tidspunkt.Tid[1]));
            _forestillinger.Add(new Forestillinger(_movies.Movies[2], _sale.sal[2], _tidspunkt.Tid[0]));
            _selectedForestillinger = null;
        }

        #endregion

        #region Properties For Databinding

        public List<Forestillinger> Forestillinger
        {
            get { return _forestillinger; }
        }

        public Forestillinger SelectedForestillinger
        {
            get { return _selectedForestillinger; }
            set
            {
                _selectedForestillinger = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region INotifyPropertyChanged code
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}