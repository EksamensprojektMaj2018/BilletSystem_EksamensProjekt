using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BilletSystem_EksamensProjekt
{
    public class TidspunktCatalog
    {
        #region Instance Field

        private List<Tidspunkt> _tid;
        private Tidspunkt _selectedTid;

        #endregion

        #region Constructor

        public TidspunktCatalog()
        {
            _tid = new List<Tidspunkt>();

            _tid.Add(new Tidspunkt("16:00"));
            _tid.Add(new Tidspunkt("18:00"));
            _tid.Add(new Tidspunkt("20:00"));

            _selectedTid = _tid[0];
        }

        #endregion

        #region Properties For Databinding

        public List<Tidspunkt> Tid
        {
            get { return _tid; }
        }

        public Tidspunkt selectedTid
        {
            get { return _selectedTid; }
            set
            {
                _selectedTid = value;
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